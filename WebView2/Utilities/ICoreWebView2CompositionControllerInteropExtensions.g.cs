#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CompositionControllerInteropExtensions
{
    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT DragEnter(this ICoreWebView2CompositionControllerInterop instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.DragEnter(dataObject, keyState, point, ref effect).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT DragLeave(this ICoreWebView2CompositionControllerInterop instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.DragLeave().ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT DragOver(this ICoreWebView2CompositionControllerInterop instance, uint keyState, POINT point, ref uint effect, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.DragOver(keyState, point, ref effect).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT Drop(this ICoreWebView2CompositionControllerInterop instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.Drop(dataObject, keyState, point, ref effect).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT DragEnter(this IComObject<ICoreWebView2CompositionControllerInterop> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true) => DragEnter(instance?.Object!, dataObject, keyState, point, ref effect, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT DragLeave(this IComObject<ICoreWebView2CompositionControllerInterop> instance, bool throwOnError = true) => DragLeave(instance?.Object!, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT DragOver(this IComObject<ICoreWebView2CompositionControllerInterop> instance, uint keyState, POINT point, ref uint effect, bool throwOnError = true) => DragOver(instance?.Object!, keyState, point, ref effect, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static HRESULT Drop(this IComObject<ICoreWebView2CompositionControllerInterop> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true) => Drop(instance?.Object!, dataObject, keyState, point, ref effect, throwOnError);

    extension(ICoreWebView2CompositionControllerInterop instance)
    {
        public IComObject<IUnknown>? AutomationProvider
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_AutomationProvider(out IUnknown value).ThrowOnError();
                return value != null ? new ComObject<IUnknown>(value) : null;
            }
        }

        public object? RootVisualTarget
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_RootVisualTarget(out IUnknown value).ThrowOnError();
                return value != null ? new ComObject<IUnknown>(value) : null;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueNative = DirectN.Extensions.Com.ComObject.FromPointer<IUnknown>(DirectN.Extensions.Com.ComObject.GetOrCreateComInstance(value, throwOnError: true));
                instance.put_RootVisualTarget(valueNative?.Object!).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2CompositionControllerInterop> instance)
    {
        public IComObject<IUnknown>? AutomationProvider
        {
            get => (instance?.Object!).AutomationProvider;
        }

        public object? RootVisualTarget
        {
            get => (instance?.Object!).RootVisualTarget;
            set => (instance?.Object!).RootVisualTarget = value;
        }
    }
}
