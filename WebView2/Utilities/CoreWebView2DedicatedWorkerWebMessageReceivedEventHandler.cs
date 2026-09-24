namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DedicatedWorkerWebMessageReceivedEventHandler(Action<ICoreWebView2DedicatedWorker, ICoreWebView2WebMessageReceivedEventArgs> handler)
    : ICoreWebView2DedicatedWorkerWebMessageReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2DedicatedWorker sender, ICoreWebView2WebMessageReceivedEventArgs args)
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
