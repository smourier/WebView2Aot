namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CustomItemSelectedEventHandler(Action<ICoreWebView2ContextMenuItem, IUnknown> handler)
    : ICoreWebView2CustomItemSelectedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ContextMenuItem sender, IUnknown args)
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
