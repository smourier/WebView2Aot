namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler(Action<ICoreWebView2, IUnknown> handler)
    : ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, IUnknown args)
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
