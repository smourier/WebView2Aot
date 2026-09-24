namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2EstimatedEndTimeChangedEventHandler(Action<ICoreWebView2DownloadOperation, IUnknown> handler)
    : ICoreWebView2EstimatedEndTimeChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DownloadOperation sender, IUnknown args)
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
