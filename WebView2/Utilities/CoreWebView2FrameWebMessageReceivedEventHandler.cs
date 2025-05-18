namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2FrameWebMessageReceivedEventHandler(Action<ICoreWebView2Frame, ICoreWebView2WebMessageReceivedEventArgs> handler)
    : ICoreWebView2FrameWebMessageReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2Frame sender, ICoreWebView2WebMessageReceivedEventArgs args)
    {
        handler(sender, args);
        return 0;
    }
}
