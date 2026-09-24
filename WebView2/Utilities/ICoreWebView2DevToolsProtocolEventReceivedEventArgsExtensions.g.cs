#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DevToolsProtocolEventReceivedEventArgsExtensions
{
    extension(ICoreWebView2DevToolsProtocolEventReceivedEventArgs instance)
    {
        public string? ParameterObjectAsJson
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ParameterObjectAsJson(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2DevToolsProtocolEventReceivedEventArgs2"/>.</remarks>
        public string? SessionId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2DevToolsProtocolEventReceivedEventArgs2>(instance) is not { } typed)
                    return default;

                typed.get_SessionId(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }
    }

    extension(IComObject<ICoreWebView2DevToolsProtocolEventReceivedEventArgs> instance)
    {
        public string? ParameterObjectAsJson
        {
            get => (instance?.Object!).ParameterObjectAsJson;
        }

        /// <remarks>Requires <see cref="ICoreWebView2DevToolsProtocolEventReceivedEventArgs2"/>.</remarks>
        public string? SessionId
        {
            get => (instance?.Object!).SessionId;
        }
    }
}
