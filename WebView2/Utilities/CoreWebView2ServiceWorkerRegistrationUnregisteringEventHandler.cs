namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler(Action<ICoreWebView2ServiceWorkerRegistration, IUnknown> handler)
    : ICoreWebView2ServiceWorkerRegistrationUnregisteringEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2ServiceWorkerRegistration sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
