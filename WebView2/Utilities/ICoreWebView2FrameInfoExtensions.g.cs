#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameInfoExtensions
{
    extension(ICoreWebView2FrameInfo instance)
    {
        public string? Name
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Name(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? Source
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Source(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2FrameInfo2"/>.</remarks>
        public IComObject<ICoreWebView2FrameInfo>? ParentFrameInfo
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2FrameInfo2>(instance) is not { } typed)
                    return default;

                typed.get_ParentFrameInfo(out ICoreWebView2FrameInfo value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2FrameInfo>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2FrameInfo2"/>.</remarks>
        public uint FrameId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2FrameInfo2>(instance) is not { } typed)
                    return default;

                uint value = default;
                typed.get_FrameId(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2FrameInfo2"/>.</remarks>
        public COREWEBVIEW2_FRAME_KIND FrameKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2FrameInfo2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_FRAME_KIND value = default;
                typed.get_FrameKind(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2FrameInfo> instance)
    {
        public string? Name
        {
            get => (instance?.Object!).Name;
        }

        public string? Source
        {
            get => (instance?.Object!).Source;
        }

        /// <remarks>Requires <see cref="ICoreWebView2FrameInfo2"/>.</remarks>
        public IComObject<ICoreWebView2FrameInfo>? ParentFrameInfo
        {
            get => (instance?.Object!).ParentFrameInfo;
        }

        /// <remarks>Requires <see cref="ICoreWebView2FrameInfo2"/>.</remarks>
        public uint FrameId
        {
            get => (instance?.Object!).FrameId;
        }

        /// <remarks>Requires <see cref="ICoreWebView2FrameInfo2"/>.</remarks>
        public COREWEBVIEW2_FRAME_KIND FrameKind
        {
            get => (instance?.Object!).FrameKind;
        }
    }
}
