namespace WebView2.Utilities;

[GeneratedComClass]
public partial class CoreWebView2DragStartingEventHandler(Action<ICoreWebView2CompositionController, ICoreWebView2DragStartingEventArgs> handler)
    : ICoreWebView2DragStartingEventHandler
{
    public virtual HRESULT Invoke(ICoreWebView2CompositionController sender, ICoreWebView2DragStartingEventArgs args)
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
