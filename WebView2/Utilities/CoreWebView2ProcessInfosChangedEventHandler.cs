namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ProcessInfosChangedEventHandler(Action<ICoreWebView2Environment, IUnknown> handler)
    : ICoreWebView2ProcessInfosChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Environment sender, IUnknown args)
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
