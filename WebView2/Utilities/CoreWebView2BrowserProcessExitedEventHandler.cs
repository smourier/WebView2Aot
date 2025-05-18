namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2BrowserProcessExitedEventHandler(Action<ICoreWebView2Environment, ICoreWebView2BrowserProcessExitedEventArgs> handler)
    : ICoreWebView2BrowserProcessExitedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Environment sender, ICoreWebView2BrowserProcessExitedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
