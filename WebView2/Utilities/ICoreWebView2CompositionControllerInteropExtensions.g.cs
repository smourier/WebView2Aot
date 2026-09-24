#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CompositionControllerInteropExtensions
{
    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void DragEnter(this ICoreWebView2CompositionControllerInterop instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return;

        typed.DragEnter(dataObject, keyState, point, ref effect).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void DragLeave(this ICoreWebView2CompositionControllerInterop instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return;

        typed.DragLeave().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void DragOver(this ICoreWebView2CompositionControllerInterop instance, uint keyState, POINT point, ref uint effect)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return;

        typed.DragOver(keyState, point, ref effect).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void Drop(this ICoreWebView2CompositionControllerInterop instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop2>(instance) is not { } typed)
            return;

        typed.Drop(dataObject, keyState, point, ref effect).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void DragEnter(this IComObject<ICoreWebView2CompositionControllerInterop> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect) => DragEnter(instance?.Object!, dataObject, keyState, point, ref effect);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void DragLeave(this IComObject<ICoreWebView2CompositionControllerInterop> instance) => DragLeave(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void DragOver(this IComObject<ICoreWebView2CompositionControllerInterop> instance, uint keyState, POINT point, ref uint effect) => DragOver(instance?.Object!, keyState, point, ref effect);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop2"/>.</remarks>
    public static void Drop(this IComObject<ICoreWebView2CompositionControllerInterop> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect) => Drop(instance?.Object!, dataObject, keyState, point, ref effect);

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
