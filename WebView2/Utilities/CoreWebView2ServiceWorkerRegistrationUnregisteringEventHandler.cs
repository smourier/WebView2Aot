namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler(Action<ICoreWebView2ServiceWorkerRegistration, IUnknown> handler)
    : ICoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorkerRegistration sender, IUnknown args)
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
