namespace ScriptHostObjectWebView2;

public class WebViewWindow : Window
{
    private readonly HostObject _hostObject = new();
    private IComObject<ICoreWebView2Controller>? _controller;

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

        InitializeWebView();
    }

    private async void InitializeWebView()
    {
        using var env = await WebView2.Functions.CreateCoreWebView2EnvironmentWithOptionsAsync(null, WebView2Utilities.GetDefaultUserDataFolder(), null) ?? throw new InvalidOperationException();
        _controller = await env.CreateCoreWebView2ControllerAsync(Handle) ?? throw new InvalidOperationException();
        _controller.Bounds = ClientRect;
        using var webView2 = _controller.CoreWebView2 ?? throw new InvalidOperationException();

        // this is for a full support of .NET Task or Task<T> methods
        // unfortunately, uses undocumented (private) interfaces
        if (webView2.As<ICoreWebView2PrivatePartial>() is { } partial)
        {
            partial.AddHostObjectHelper(new WebViewHostObjectHelper());
            _hostObject.ContinueOnAsync = true;
            _hostObject.OneStepInvoke = true;
        }

        //webView2.OpenDevToolsWindow();

        _hostObject.ClockTick += (s, e) =>
        {
            Text = $"Javascript Tick: {e}";
        };

        webView2.AddHostObjectToScript("dotnet", _hostObject);

        // load index.html from the current assembly
        var html = Encoding.UTF8.GetString(Assembly.GetExecutingAssembly().LoadFromResource(GetType().Namespace + ".Index.html"));
        webView2.NavigateToString(html);
    }

    protected override bool OnResized(WindowResizedType type, SIZE size)
    {
        _controller?.Bounds = ClientRect;
        return base.OnResized(type, size);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            var controller = Interlocked.Exchange(ref _controller, null);
            controller?.Object.Close();
            controller?.Dispose();
        }
        base.Dispose(disposing);
    }
}
