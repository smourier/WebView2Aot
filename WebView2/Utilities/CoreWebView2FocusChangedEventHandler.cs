namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FocusChangedEventHandler(Action<ICoreWebView2Controller, IUnknown> handler)
    : ICoreWebView2FocusChangedEventHandler
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
