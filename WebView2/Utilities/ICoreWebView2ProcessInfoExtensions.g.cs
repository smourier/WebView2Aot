#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ProcessInfoExtensions
{
    extension(ICoreWebView2ProcessInfo instance)
    {
        public int ProcessId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_ProcessId(ref value).ThrowOnError();
                return value;
            }
        }

        public COREWEBVIEW2_PROCESS_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PROCESS_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2ProcessInfo> instance)
    {
        public int ProcessId
        {
            get => (instance?.Object!).ProcessId;
        }

        public COREWEBVIEW2_PROCESS_KIND Kind
        {
            get => (instance?.Object!).Kind;
        }
    }
}
