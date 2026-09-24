#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WindowFeaturesExtensions
{
    extension(ICoreWebView2WindowFeatures instance)
    {
        public bool HasPosition
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasPosition(ref value).ThrowOnError();
                return value;
            }
        }

        public bool HasSize
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_HasSize(ref value).ThrowOnError();
                return value;
            }
        }

        public uint Left
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_Left(ref value).ThrowOnError();
                return value;
            }
        }

        public uint Top
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_Top(ref value).ThrowOnError();
                return value;
            }
        }

        public uint Height
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_Height(ref value).ThrowOnError();
                return value;
            }
        }

        public uint Width
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_Width(ref value).ThrowOnError();
                return value;
            }
        }

        public bool ShouldDisplayMenuBar
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldDisplayMenuBar(ref value).ThrowOnError();
                return value;
            }
        }

        public bool ShouldDisplayStatus
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldDisplayStatus(ref value).ThrowOnError();
                return value;
            }
        }

        public bool ShouldDisplayToolbar
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldDisplayToolbar(ref value).ThrowOnError();
                return value;
            }
        }

        public bool ShouldDisplayScrollBars
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldDisplayScrollBars(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2WindowFeatures> instance)
    {
        public bool HasPosition
        {
            get => (instance?.Object!).HasPosition;
        }

        public bool HasSize
        {
            get => (instance?.Object!).HasSize;
        }

        public uint Left
        {
            get => (instance?.Object!).Left;
        }

        public uint Top
        {
            get => (instance?.Object!).Top;
        }

        public uint Height
        {
            get => (instance?.Object!).Height;
        }

        public uint Width
        {
            get => (instance?.Object!).Width;
        }

        public bool ShouldDisplayMenuBar
        {
            get => (instance?.Object!).ShouldDisplayMenuBar;
        }

        public bool ShouldDisplayStatus
        {
            get => (instance?.Object!).ShouldDisplayStatus;
        }

        public bool ShouldDisplayToolbar
        {
            get => (instance?.Object!).ShouldDisplayToolbar;
        }

        public bool ShouldDisplayScrollBars
        {
            get => (instance?.Object!).ShouldDisplayScrollBars;
        }
    }
}
