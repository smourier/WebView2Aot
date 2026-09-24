namespace HelloWebView2;

public class WebViewWindow : Window
{
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

        // use 1st arg from command line or default to Bing
        var url = CommandLine.Current.GetNullifiedArgument(0, "https://www.bing.com/");
        webView2.Navigate(url);
        OnFocusChanged(true);
    }

    protected override bool OnFocusChanged(bool setOrKill)
    {
        if (setOrKill)
        {
            if (_controller != null)
            {
                _controller.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON.COREWEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC);
                return true;
            }
        }
        return base.OnFocusChanged(setOrKill);
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
