#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2WebMessageReceivedEventArgsExtensions
{
    public static string? TryGetWebMessageAsString(this ICoreWebView2WebMessageReceivedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        string? value;
        instance.TryGetWebMessageAsString(out PWSTR valueNative).ThrowOnError();
        value = valueNative.ToStringAndDispose();
        return value;
    }

    public static string? TryGetWebMessageAsString(this IComObject<ICoreWebView2WebMessageReceivedEventArgs> instance) => TryGetWebMessageAsString(instance?.Object!);

    extension(ICoreWebView2WebMessageReceivedEventArgs instance)
    {
        public string? Source
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Source(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? WebMessageAsJson
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_WebMessageAsJson(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2WebMessageReceivedEventArgs2"/>.</remarks>
        public IComObject<ICoreWebView2ObjectCollectionView>? AdditionalObjects
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2WebMessageReceivedEventArgs2>(instance) is not { } typed)
                    return default;

                typed.get_AdditionalObjects(out ICoreWebView2ObjectCollectionView value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2ObjectCollectionView>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2WebMessageReceivedEventArgs> instance)
    {
        public string? Source
        {
            get => (instance?.Object!).Source;
        }

        public string? WebMessageAsJson
        {
            get => (instance?.Object!).WebMessageAsJson;
        }

        /// <remarks>Requires <see cref="ICoreWebView2WebMessageReceivedEventArgs2"/>.</remarks>
        public IComObject<ICoreWebView2ObjectCollectionView>? AdditionalObjects
        {
            get => (instance?.Object!).AdditionalObjects;
        }
    }
}
