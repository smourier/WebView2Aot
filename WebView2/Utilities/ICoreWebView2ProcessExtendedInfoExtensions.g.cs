#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ProcessExtendedInfoExtensions
{
    extension(ICoreWebView2ProcessExtendedInfo instance)
    {
        public IComObject<ICoreWebView2ProcessInfo>? ProcessInfo
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ProcessInfo(out ICoreWebView2ProcessInfo value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ProcessInfo>(value) : null;
            }
        }

        public IComObject<ICoreWebView2FrameInfoCollection>? AssociatedFrameInfos
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_AssociatedFrameInfos(out ICoreWebView2FrameInfoCollection value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2FrameInfoCollection>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2ProcessExtendedInfo> instance)
    {
        public IComObject<ICoreWebView2ProcessInfo>? ProcessInfo
        {
            get => (instance?.Object!).ProcessInfo;
        }

        public IComObject<ICoreWebView2FrameInfoCollection>? AssociatedFrameInfos
        {
            get => (instance?.Object!).AssociatedFrameInfos;
        }
    }
}
