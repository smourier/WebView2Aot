namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2ScriptDialogOpeningEventHandler(Action<ICoreWebView2, ICoreWebView2ScriptDialogOpeningEventArgs> handler)
    : ICoreWebView2ScriptDialogOpeningEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2 sender, ICoreWebView2ScriptDialogOpeningEventArgs args)
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
