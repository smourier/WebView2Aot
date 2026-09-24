namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DedicatedWorkerDedicatedWorkerCreatedEventHandler(Action<ICoreWebView2DedicatedWorker, ICoreWebView2DedicatedWorkerCreatedEventArgs> handler)
    : ICoreWebView2DedicatedWorkerDedicatedWorkerCreatedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DedicatedWorker sender, ICoreWebView2DedicatedWorkerCreatedEventArgs args)
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
