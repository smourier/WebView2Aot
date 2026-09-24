namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameNameChangedEventHandler(Action<ICoreWebView2Frame, IUnknown> handler)
    : ICoreWebView2FrameNameChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, IUnknown args)
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
