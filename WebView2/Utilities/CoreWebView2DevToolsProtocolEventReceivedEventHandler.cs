namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DevToolsProtocolEventReceivedEventHandler(Action<ICoreWebView2, ICoreWebView2DevToolsProtocolEventReceivedEventArgs> handler)
    : ICoreWebView2DevToolsProtocolEventReceivedEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2DevToolsProtocolEventReceivedEventArgs args)
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
