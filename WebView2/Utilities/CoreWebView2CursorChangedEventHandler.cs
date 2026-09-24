namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2CursorChangedEventHandler(Action<ICoreWebView2CompositionController, IUnknown> handler)
    : ICoreWebView2CursorChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2CompositionController sender, IUnknown args)
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
