namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2PermissionRequestedEventHandler(Action<ICoreWebView2, ICoreWebView2PermissionRequestedEventArgs> handler)
    : ICoreWebView2PermissionRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2PermissionRequestedEventArgs args)
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
