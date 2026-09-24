namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2AcceleratorKeyPressedEventHandler(Action<ICoreWebView2Controller, ICoreWebView2AcceleratorKeyPressedEventArgs> handler)
    : ICoreWebView2AcceleratorKeyPressedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Controller sender, ICoreWebView2AcceleratorKeyPressedEventArgs args)
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
