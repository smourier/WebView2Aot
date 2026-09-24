#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2SharedBufferExtensions
{
    extension(ICoreWebView2SharedBuffer instance)
    {
        public ulong Size
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                ulong value = default;
                instance.get_Size(ref value).ThrowOnError();
                return value;
            }
        }

        public nint Buffer
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Buffer(out nint value).ThrowOnError();
                return value;
            }
        }

        public HANDLE FileMappingHandle
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                HANDLE value = default;
                instance.get_FileMappingHandle(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2SharedBuffer> instance)
    {
        public ulong Size
        {
            get => (instance?.Object!).Size;
        }

        public nint Buffer
        {
            get => (instance?.Object!).Buffer;
        }

        public HANDLE FileMappingHandle
        {
            get => (instance?.Object!).FileMappingHandle;
        }
    }
}
