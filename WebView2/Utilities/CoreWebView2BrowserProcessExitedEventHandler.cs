namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2BrowserProcessExitedEventHandler(Action<ICoreWebView2Environment, ICoreWebView2BrowserProcessExitedEventArgs> handler)
    : ICoreWebView2BrowserProcessExitedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Environment sender, ICoreWebView2BrowserProcessExitedEventArgs args)
    {
        try
        {
            handler(sender, args);
        }
        finally
        {
            DirectN.Extensions.Com.ComObject.FinalRelease((object)sender as System.Runtime.InteropServices.Marshalling.ComObject);
        }

        return 0;
    }
}
