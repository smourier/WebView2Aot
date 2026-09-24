namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2RasterizationScaleChangedEventHandler(Action<ICoreWebView2Controller, IUnknown> handler)
    : ICoreWebView2RasterizationScaleChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Controller sender, IUnknown args)
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
