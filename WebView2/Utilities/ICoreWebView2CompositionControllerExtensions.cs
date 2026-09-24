namespace WebView2.Utilities;

public static partial class ICoreWebView2CompositionControllerExtensions
{
    /// <remarks>Requires <see cref="ICoreWebView2ExperimentalCompositionController4"/>.</remarks>
    public static IComObject<ICoreWebView2PointerInfo>? CreateCoreWebView2PointerInfoFromPointerId(this IComObject<ICoreWebView2CompositionController> controller, uint pointerId, HWND parentWindow, D2D_MATRIX_4X4_F transform) => CreateCoreWebView2PointerInfoFromPointerId(controller?.Object!, pointerId, parentWindow, transform);

    /// <remarks>Requires <see cref="ICoreWebView2ExperimentalCompositionController4"/>.</remarks>
    public static IComObject<ICoreWebView2PointerInfo>? CreateCoreWebView2PointerInfoFromPointerId(this ICoreWebView2CompositionController controller, uint pointerId, HWND parentWindow, D2D_MATRIX_4X4_F transform)
    {
        ArgumentNullException.ThrowIfNull(controller);

        if (WebView2Utilities.GetInterface<ICoreWebView2ExperimentalCompositionController4>(controller) is not { } experimental)
            return null;

        experimental.CreateCoreWebView2PointerInfoFromPointerId(pointerId, parentWindow, transform, out var value).ThrowOnError();
        return value != null ? new ComObject<ICoreWebView2PointerInfo>(value) : null;
    }
}
