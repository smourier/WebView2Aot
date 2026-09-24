namespace WebView2.Utilities;

public static class ICoreWebView2PrivateHostObjectAsyncMethodContinuationExtensions
{
    public static void Invoke(this IComObject<ICoreWebView2PrivateHostObjectAsyncMethodContinuation> continuation, HRESULT errorCode, object? result) => Invoke(continuation?.Object!, errorCode, result);
    public static void Invoke(this ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation, HRESULT errorCode, object? result)
    {
        ArgumentNullException.ThrowIfNull(continuation);

        using var variant = new DirectN.Extensions.Utilities.Variant(result);
        continuation.Invoke(errorCode, ref variant.RefDetached).ThrowOnError();
    }
}
