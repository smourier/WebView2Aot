namespace MarkdownViewer;

internal static class Program
{
    public const string AppId = "MarkdownViewer";
    public static string? WebViewVersion { get; private set; }
    public static string WebView2DownloadUrl { get; } = "https://go.microsoft.com/fwlink/p/?LinkId=2124703";

    [STAThread]
    static void Main()
    {
        try
        {
            ApplicationConfiguration.Initialize();

            // this checks WebView2Loader.dll is present somewhere (file path or embedded resource)
            WebView2Utilities.Initialize(Assembly.GetEntryAssembly());
            WebViewVersion = WebView2Utilities.GetAvailableCoreWebView2BrowserVersionString();
            if (string.IsNullOrWhiteSpace(WebViewVersion))
            {
                var page = new TaskDialogPage()
                {
                    EnableLinks = true,
                    AllowCancel = false,
                    AllowMinimize = false,
                    Heading = "Microsoft Edge WebView2 Runtime is not installed.",
                    Text = $"This application requires the WebView2 runtime to be installed. Please install it from the Microsoft website at <A HREF=\"{WebView2DownloadUrl}\">{WebView2DownloadUrl}</A> and restart this application.",
                    Icon = TaskDialogIcon.Warning,

                };

                page.LinkClicked += (s, e) =>
                {
                    Process.Start(new ProcessStartInfo { UseShellExecute = true, FileName = WebView2DownloadUrl });
                    page.BoundDialog!.Close();
                };

                TaskDialog.ShowDialog(page);
                return;
            }

            Application.Run(new Main());
        }
        catch (Exception ex)
        {
            var page = new TaskDialogPage()
            {
                AllowCancel = false,
                AllowMinimize = false,
                Heading = "An error has occurred",
                Text = DirectN.Extensions.Utilities.Extensions.GetAllMessages(ex, "."),
                Icon = TaskDialogIcon.Error,

            };
            TaskDialog.ShowDialog(page);
        }
    }
}