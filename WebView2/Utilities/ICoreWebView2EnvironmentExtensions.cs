namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentExtensions
{
    /// <remarks>Requires <see cref="ICoreWebView2Environment14"/>.</remarks>
    public static IComObject<ICoreWebView2ObjectCollection>? CreateObjectCollection(this IComObject<ICoreWebView2Environment> environment, IEnumerable<object> items) => CreateObjectCollection(environment?.Object!, items);

    /// <remarks>Requires <see cref="ICoreWebView2Environment14"/>.</remarks>
    public static unsafe IComObject<ICoreWebView2ObjectCollection>? CreateObjectCollection(this ICoreWebView2Environment environment, IEnumerable<object> items)
    {
        ArgumentNullException.ThrowIfNull(environment);
        ArgumentNullException.ThrowIfNull(items);

        if (WebView2Utilities.GetInterface<ICoreWebView2Environment14>(environment) is not { } environment14)
            return null;

        var unknowns = new List<nint>();
        try
        {
            foreach (var item in items)
            {
                unknowns.Add(DirectN.Extensions.Com.ComObject.GetOrCreateComInstance(item, throwOnError: true));
            }

            var array = unknowns.ToArray();
            fixed (nint* pointer = array)
            {
                environment14.CreateObjectCollection((uint)array.Length, (nint)pointer, out var collection).ThrowOnError();
                return collection != null ? new ComObject<ICoreWebView2ObjectCollection>(collection) : null;
            }
        }
        finally
        {
            foreach (var unknown in unknowns)
            {
                if (unknown != 0)
                {
                    Marshal.Release(unknown);
                }
            }
        }
    }
}
