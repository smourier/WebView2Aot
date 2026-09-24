namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2SharedWorkerCreatedEventHandler(Action<ICoreWebView2SharedWorkerManager, ICoreWebView2SharedWorkerCreatedEventArgs> handler)
    : ICoreWebView2SharedWorkerCreatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2SharedWorkerManager sender, ICoreWebView2SharedWorkerCreatedEventArgs args)
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
