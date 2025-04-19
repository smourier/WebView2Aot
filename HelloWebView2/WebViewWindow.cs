namespace HelloWebView2;

public class WebViewWindow : Window
{
    private ComObject<ICoreWebView2Controller>? _controller;

    public WebViewWindow(string? title = null) : base(title)
    {
        WebView2Utilities.Initialize();
        WebView2.Functions.CreateCoreWebView2EnvironmentWithOptions(PWSTR.Null, PWSTR.Null, null!,
            new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler((error, env) =>
            {
                env.CreateCoreWebView2Controller(Handle, new CoreWebView2CreateCoreWebView2ControllerCompletedHandler((error, controller) =>
                {
                    _controller = new ComObject<ICoreWebView2Controller>(controller);
                    controller.put_Bounds(ClientRect).ThrowOnError();
                    controller.get_CoreWebView2(out var webView2).ThrowOnError();
                    webView2.Navigate(PWSTR.From("https://www.bing.com/"));
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
