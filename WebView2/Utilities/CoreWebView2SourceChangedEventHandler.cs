namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SourceChangedEventHandler(Action<ICoreWebView2, ICoreWebView2SourceChangedEventArgs> handler)
    : ICoreWebView2SourceChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2SourceChangedEventArgs args)
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
