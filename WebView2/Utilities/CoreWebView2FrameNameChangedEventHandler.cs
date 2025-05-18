namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameNameChangedEventHandler(Action<ICoreWebView2Frame, IUnknown> handler)
    : ICoreWebView2FrameNameChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
