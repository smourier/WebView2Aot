namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DedicatedWorkerDestroyingEventHandler(Action<ICoreWebView2DedicatedWorker, IUnknown> handler)
    : ICoreWebView2DedicatedWorkerDestroyingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DedicatedWorker sender, IUnknown args)
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
