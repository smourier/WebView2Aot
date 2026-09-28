#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CompositionControllerExtensions
{
    public static HRESULT SendMouseInput(this ICoreWebView2CompositionController instance, COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, uint mouseData, POINT point, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.SendMouseInput(eventKind, virtualKeys, mouseData, point).ThrowOnError(throwOnError);
    }

    public static HRESULT SendPointerInput(this ICoreWebView2CompositionController instance, COREWEBVIEW2_POINTER_EVENT_KIND eventKind, ICoreWebView2PointerInfo pointerInfo, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        return instance.SendPointerInput(eventKind, pointerInfo).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT DragEnter(this ICoreWebView2CompositionController instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.DragEnter(dataObject, keyState, point, ref effect).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT DragLeave(this ICoreWebView2CompositionController instance, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.DragLeave().ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT DragOver(this ICoreWebView2CompositionController instance, uint keyState, POINT point, ref uint effect, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.DragOver(keyState, point, ref effect).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT Drop(this ICoreWebView2CompositionController instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return DirectN.Constants.E_NOINTERFACE;

        return typed.Drop(dataObject, keyState, point, ref effect).ThrowOnError(throwOnError);
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController4"/>.</remarks>
    public static COREWEBVIEW2_NON_CLIENT_REGION_KIND GetNonClientRegionAtPoint(this ICoreWebView2CompositionController instance, POINT point)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController4>(instance) is not { } typed)
            return default;

        COREWEBVIEW2_NON_CLIENT_REGION_KIND value;
        COREWEBVIEW2_NON_CLIENT_REGION_KIND valueNative = default;
        typed.GetNonClientRegionAtPoint(point, ref valueNative).ThrowOnError();
        value = valueNative;
        return value;
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController4"/>.</remarks>
    public static IComObject<ICoreWebView2RegionRectCollectionView>? QueryNonClientRegion(this ICoreWebView2CompositionController instance, COREWEBVIEW2_NON_CLIENT_REGION_KIND kind)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController4>(instance) is not { } typed)
            return default;

        IComObject<ICoreWebView2RegionRectCollectionView>? rects;
        typed.QueryNonClientRegion(kind, out ICoreWebView2RegionRectCollectionView rectsNative).ThrowOnError();
        rects = rectsNative != null ? new ComObject<ICoreWebView2RegionRectCollectionView>(rectsNative) : null;
        return rects;
    }

    public static HRESULT SendMouseInput(this IComObject<ICoreWebView2CompositionController> instance, COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, uint mouseData, POINT point, bool throwOnError = true) => SendMouseInput(instance?.Object!, eventKind, virtualKeys, mouseData, point, throwOnError);

    public static HRESULT SendPointerInput(this IComObject<ICoreWebView2CompositionController> instance, COREWEBVIEW2_POINTER_EVENT_KIND eventKind, IComObject<ICoreWebView2PointerInfo> pointerInfo, bool throwOnError = true) => SendPointerInput(instance?.Object!, eventKind, pointerInfo?.Object!, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT DragEnter(this IComObject<ICoreWebView2CompositionController> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true) => DragEnter(instance?.Object!, dataObject, keyState, point, ref effect, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT DragLeave(this IComObject<ICoreWebView2CompositionController> instance, bool throwOnError = true) => DragLeave(instance?.Object!, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT DragOver(this IComObject<ICoreWebView2CompositionController> instance, uint keyState, POINT point, ref uint effect, bool throwOnError = true) => DragOver(instance?.Object!, keyState, point, ref effect, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static HRESULT Drop(this IComObject<ICoreWebView2CompositionController> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect, bool throwOnError = true) => Drop(instance?.Object!, dataObject, keyState, point, ref effect, throwOnError);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController4"/>.</remarks>
    public static COREWEBVIEW2_NON_CLIENT_REGION_KIND GetNonClientRegionAtPoint(this IComObject<ICoreWebView2CompositionController> instance, POINT point) => GetNonClientRegionAtPoint(instance?.Object!, point);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController4"/>.</remarks>
    public static IComObject<ICoreWebView2RegionRectCollectionView>? QueryNonClientRegion(this IComObject<ICoreWebView2CompositionController> instance, COREWEBVIEW2_NON_CLIENT_REGION_KIND kind) => QueryNonClientRegion(instance?.Object!, kind);

    extension(ICoreWebView2CompositionController instance)
    {
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

        public HCURSOR Cursor
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                HCURSOR value = default;
                instance.get_Cursor(ref value).ThrowOnError();
                return value;
            }
        }

        public uint SystemCursorId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_SystemCursorId(ref value).ThrowOnError();
                return value;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2CompositionController2"/>.</remarks>
        public IComObject<IUnknown>? AutomationProvider
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController2>(instance) is not { } typed)
                    return default;

                typed.get_AutomationProvider(out IUnknown value).ThrowOnError();
                return value != null ? new ComObject<IUnknown>(value) : null;
            }
        }
    }

    extension(IComObject<ICoreWebView2CompositionController> instance)
    {
        public object? RootVisualTarget
        {
            get => (instance?.Object!).RootVisualTarget;
            set => (instance?.Object!).RootVisualTarget = value;
        }

        public HCURSOR Cursor
        {
            get => (instance?.Object!).Cursor;
        }

        public uint SystemCursorId
        {
            get => (instance?.Object!).SystemCursorId;
        }

        /// <remarks>Requires <see cref="ICoreWebView2CompositionController2"/>.</remarks>
        public IComObject<IUnknown>? AutomationProvider
        {
            get => (instance?.Object!).AutomationProvider;
        }
    }
}
