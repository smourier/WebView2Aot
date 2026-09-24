#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2BrowserProcessExitedEventArgsExtensions
{
    extension(ICoreWebView2BrowserProcessExitedEventArgs instance)
    {
        public COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND value = default;
                instance.get_BrowserProcessExitKind(ref value).ThrowOnError();
                return value;
            }
        }

        public uint BrowserProcessId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_BrowserProcessId(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2BrowserProcessExitedEventArgs> instance)
    {
        public COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind
        {
            get => (instance?.Object!).BrowserProcessExitKind;
        }

        public uint BrowserProcessId
        {
            get => (instance?.Object!).BrowserProcessId;
        }
    }
}
