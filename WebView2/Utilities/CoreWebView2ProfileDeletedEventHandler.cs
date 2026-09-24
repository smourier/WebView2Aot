namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProfileDeletedEventHandler(Action<ICoreWebView2Profile, IUnknown> handler)
    : ICoreWebView2ProfileDeletedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Profile sender, IUnknown args)
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
