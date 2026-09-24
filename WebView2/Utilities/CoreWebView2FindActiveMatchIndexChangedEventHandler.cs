namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FindActiveMatchIndexChangedEventHandler(Action<ICoreWebView2Find, IUnknown> handler)
    : ICoreWebView2FindActiveMatchIndexChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Find sender, IUnknown args)
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
