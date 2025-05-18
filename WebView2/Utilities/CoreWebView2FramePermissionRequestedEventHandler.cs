namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FramePermissionRequestedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2PermissionRequestedEventArgs2> handler)
    : ICoreWebView2FramePermissionRequestedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2PermissionRequestedEventArgs2 args)
    {
        handler(sender, args);
        return 0;
    }
}
