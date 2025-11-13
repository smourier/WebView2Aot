namespace ScriptHostObjectWebView2;

public class WebViewWindow : Window
{
    private readonly HostObject _hostObject = new();
    private ComObject<ICoreWebView2Controller>? _controller;

    public WebViewWindow(string? title = null) : base(title)
    {
        // this checks WebView2Loader.dll is present somewhere (file path or embedded resource)
        WebView2Utilities.Initialize(Assembly.GetEntryAssembly());

        // this checks WebView2 itself is installed
        var browserVersion = WebView2Utilities.GetAvailableCoreWebView2BrowserVersionString();
        if (browserVersion != null)
        {
            Text = $"{Text} - WebView2 V{browserVersion}";
        }
        else
        {
            Text = $"{Text} - WebView2 was not found";
        }

        WebView2.Functions.CreateCoreWebView2EnvironmentWithOptions(PWSTR.Null, PWSTR.Null, null!,
            new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler((result, env) =>
            {
                env.CreateCoreWebView2Controller(Handle, new CoreWebView2CreateCoreWebView2ControllerCompletedHandler((result, controller) =>
                {
                    _controller = new ComObject<ICoreWebView2Controller>(controller);
                    controller.put_Bounds(ClientRect).ThrowOnError();
                    controller.get_CoreWebView2(out var webView2).ThrowOnError();

                    // this is for a full support of .NET Task or Task<T> methods
                    // unfortunately, uses undocumented (private) interfaces
                    if (webView2 is ICoreWebView2PrivatePartial partial)
                    {
                        partial.AddHostObjectHelper(new WebViewHostObjectHelper()).ThrowOnError();
                        _hostObject.ContinueOnAsync = true;
                    }

                    webView2.OpenDevToolsWindow();
                    _hostObject.ClockTick += (s, e) =>
                    {
                        Text = $"Javascript Tick: {e}";
                    };

                    // get IUnknown from the host object and wrap it in a VARIANT
                    DirectN.Extensions.Com.ComObject.WithComInstance(_hostObject, unk =>
                    {
                        using var variant = new Variant(unk, VARENUM.VT_UNKNOWN);
                        var detached = variant.Detached;
                        webView2.AddHostObjectToScript(PWSTR.From("dotnet"), ref detached).ThrowOnError();
                    }, true);

                    // load index.html from the current assembly
                    var html = Encoding.UTF8.GetString(Assembly.GetExecutingAssembly().LoadFromResource(GetType().Namespace + ".Index.html"));
                    webView2.NavigateToString(PWSTR.From(html));
                }));
            }));
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        _controller?.Object.put_Bounds(ClientRect).ThrowOnError();
        return base.OnResized(type, size);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _controller?.Dispose();
        }
        base.Dispose(disposing);
    }
}
