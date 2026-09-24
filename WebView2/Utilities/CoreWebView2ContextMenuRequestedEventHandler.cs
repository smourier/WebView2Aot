namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ContextMenuRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2ContextMenuRequestedEventArgs> handler)
    : ICoreWebView2ContextMenuRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ContextMenuRequestedEventArgs args)
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
