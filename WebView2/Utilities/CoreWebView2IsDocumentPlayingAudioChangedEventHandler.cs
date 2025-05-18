namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2IsDocumentPlayingAudioChangedEventHandler(Action<ICoreWebView2, IUnknown> handler)
    : ICoreWebView2IsDocumentPlayingAudioChangedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, IUnknown args)
    {
        handler(sender, args);
        return 0;
    }
}
