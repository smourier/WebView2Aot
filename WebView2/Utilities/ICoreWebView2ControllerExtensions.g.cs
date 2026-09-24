#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ControllerExtensions
{
    public static void SetBoundsAndZoomFactor(this ICoreWebView2Controller instance, RECT bounds, double zoomFactor)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.SetBoundsAndZoomFactor(bounds, zoomFactor).ThrowOnError();
    }

    public static void MoveFocus(this ICoreWebView2Controller instance, COREWEBVIEW2_MOVE_FOCUS_REASON reason)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.MoveFocus(reason).ThrowOnError();
    }

    public static void NotifyParentWindowPositionChanged(this ICoreWebView2Controller instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.NotifyParentWindowPositionChanged().ThrowOnError();
    }

    public static void Close(this ICoreWebView2Controller instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Close().ThrowOnError();
    }

    public static void SetBoundsAndZoomFactor(this IComObject<ICoreWebView2Controller> instance, RECT bounds, double zoomFactor) => SetBoundsAndZoomFactor(instance?.Object!, bounds, zoomFactor);

    public static void MoveFocus(this IComObject<ICoreWebView2Controller> instance, COREWEBVIEW2_MOVE_FOCUS_REASON reason) => MoveFocus(instance?.Object!, reason);

    public static void NotifyParentWindowPositionChanged(this IComObject<ICoreWebView2Controller> instance) => NotifyParentWindowPositionChanged(instance?.Object!);

    public static void Close(this IComObject<ICoreWebView2Controller> instance) => Close(instance?.Object!);

    extension(ICoreWebView2Controller instance)
    {
        public bool IsVisible
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsVisible(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_IsVisible(value).ThrowOnError();
            }
        }

        public RECT Bounds
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                RECT value = default;
                instance.get_Bounds(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Bounds(value).ThrowOnError();
            }
        }

        public double ZoomFactor
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_ZoomFactor(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ZoomFactor(value).ThrowOnError();
            }
        }

        public HWND ParentWindow
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                HWND value = default;
                instance.get_ParentWindow(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ParentWindow(value).ThrowOnError();
            }
        }

        public IComObject<ICoreWebView2>? CoreWebView2
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_CoreWebView2(out ICoreWebView2 value).ThrowOnError();
                return value != null ? new ComObject<ICoreWebView2>(value) : null;
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller2"/>.</remarks>
        public COREWEBVIEW2_COLOR DefaultBackgroundColor
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_COLOR value = default;
                typed.get_DefaultBackgroundColor(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller2>(instance) is not { } typed)
                    return;

                typed.put_DefaultBackgroundColor(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
        public double RasterizationScale
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(instance) is not { } typed)
                    return default;

                double value = default;
                typed.get_RasterizationScale(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(instance) is not { } typed)
                    return;

                typed.put_RasterizationScale(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
        public bool ShouldDetectMonitorScaleChanges
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_ShouldDetectMonitorScaleChanges(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(instance) is not { } typed)
                    return;

                typed.put_ShouldDetectMonitorScaleChanges(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
        public COREWEBVIEW2_BOUNDS_MODE BoundsMode
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_BOUNDS_MODE value = default;
                typed.get_BoundsMode(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller3>(instance) is not { } typed)
                    return;

                typed.put_BoundsMode(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller4"/>.</remarks>
        public bool AllowExternalDrop
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller4>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_AllowExternalDrop(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2Controller4>(instance) is not { } typed)
                    return;

                typed.put_AllowExternalDrop(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2Controller> instance)
    {
        public bool IsVisible
        {
            get => (instance?.Object!).IsVisible;
            set => (instance?.Object!).IsVisible = value;
        }

        public RECT Bounds
        {
            get => (instance?.Object!).Bounds;
            set => (instance?.Object!).Bounds = value;
        }

        public double ZoomFactor
        {
            get => (instance?.Object!).ZoomFactor;
            set => (instance?.Object!).ZoomFactor = value;
        }

        public HWND ParentWindow
        {
            get => (instance?.Object!).ParentWindow;
            set => (instance?.Object!).ParentWindow = value;
        }

        public IComObject<ICoreWebView2>? CoreWebView2
        {
            get => (instance?.Object!).CoreWebView2;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller2"/>.</remarks>
        public COREWEBVIEW2_COLOR DefaultBackgroundColor
        {
            get => (instance?.Object!).DefaultBackgroundColor;
            set => (instance?.Object!).DefaultBackgroundColor = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
        public double RasterizationScale
        {
            get => (instance?.Object!).RasterizationScale;
            set => (instance?.Object!).RasterizationScale = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
        public bool ShouldDetectMonitorScaleChanges
        {
            get => (instance?.Object!).ShouldDetectMonitorScaleChanges;
            set => (instance?.Object!).ShouldDetectMonitorScaleChanges = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller3"/>.</remarks>
        public COREWEBVIEW2_BOUNDS_MODE BoundsMode
        {
            get => (instance?.Object!).BoundsMode;
            set => (instance?.Object!).BoundsMode = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2Controller4"/>.</remarks>
        public bool AllowExternalDrop
        {
            get => (instance?.Object!).AllowExternalDrop;
            set => (instance?.Object!).AllowExternalDrop = value;
        }
    }
}
