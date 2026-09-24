#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CompositionControllerExtensions
{
    public static void SendMouseInput(this ICoreWebView2CompositionController instance, COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, uint mouseData, POINT point)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.SendMouseInput(eventKind, virtualKeys, mouseData, point).ThrowOnError();
    }

    public static void SendPointerInput(this ICoreWebView2CompositionController instance, COREWEBVIEW2_POINTER_EVENT_KIND eventKind, ICoreWebView2PointerInfo pointerInfo)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.SendPointerInput(eventKind, pointerInfo).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void DragEnter(this ICoreWebView2CompositionController instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return;

        typed.DragEnter(dataObject, keyState, point, ref effect).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void DragLeave(this ICoreWebView2CompositionController instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return;

        typed.DragLeave().ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void DragOver(this ICoreWebView2CompositionController instance, uint keyState, POINT point, ref uint effect)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return;

        typed.DragOver(keyState, point, ref effect).ThrowOnError();
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void Drop(this ICoreWebView2CompositionController instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect)
    {
        ArgumentNullException.ThrowIfNull(instance);

        if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController3>(instance) is not { } typed)
            return;

        typed.Drop(dataObject, keyState, point, ref effect).ThrowOnError();
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

    public static void SendMouseInput(this IComObject<ICoreWebView2CompositionController> instance, COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, uint mouseData, POINT point) => SendMouseInput(instance?.Object!, eventKind, virtualKeys, mouseData, point);

    public static void SendPointerInput(this IComObject<ICoreWebView2CompositionController> instance, COREWEBVIEW2_POINTER_EVENT_KIND eventKind, IComObject<ICoreWebView2PointerInfo> pointerInfo) => SendPointerInput(instance?.Object!, eventKind, pointerInfo?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void DragEnter(this IComObject<ICoreWebView2CompositionController> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect) => DragEnter(instance?.Object!, dataObject, keyState, point, ref effect);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void DragLeave(this IComObject<ICoreWebView2CompositionController> instance) => DragLeave(instance?.Object!);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void DragOver(this IComObject<ICoreWebView2CompositionController> instance, uint keyState, POINT point, ref uint effect) => DragOver(instance?.Object!, keyState, point, ref effect);

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController3"/>.</remarks>
    public static void Drop(this IComObject<ICoreWebView2CompositionController> instance, IDataObject dataObject, uint keyState, POINT point, ref uint effect) => Drop(instance?.Object!, dataObject, keyState, point, ref effect);

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
