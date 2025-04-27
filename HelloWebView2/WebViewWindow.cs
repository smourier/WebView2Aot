namespace HelloWebView2;

public class WebViewWindow : Window
{
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

                    // use 1st arg from command line or default to Bing
                    var url = CommandLine.Current.GetNullifiedArgument(0, "https://www.bing.com/");
                    webView2.Navigate(PWSTR.From(url));
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
