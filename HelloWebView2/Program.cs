namespace HelloWebView2;

internal static class Program
{
    [STAThread] // WebView2 needs this
    static void Main()
    {
        using var app = new Application();
        using var win = new WebViewWindow("Hello Web View");
        win.ResizeClient(1000, 800);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}