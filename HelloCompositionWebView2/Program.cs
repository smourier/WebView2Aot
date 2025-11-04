namespace HelloCompositionWebView2;

internal static class Program
{
    [STAThread] // WebView2 needs this
    static void Main()
    {
        using var app = new CompositionApplication();
        using var win = new WebViewCompositionWindow($"Hello {RuntimeInformation.ProcessArchitecture} AOT - Composition");
        win.IsDropTarget = true;
        win.ResizeClient(1000, 800);
        win.Center();
        win.Show();
        win.SetForeground();
        app.Run();
    }
}