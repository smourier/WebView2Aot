namespace WebView2.Utilities;

public static partial class ICoreWebView2CustomSchemeRegistrationExtensions
{
    public static IReadOnlyList<string?> GetAllowedOrigins(this IComObject<ICoreWebView2CustomSchemeRegistration> registration) => GetAllowedOrigins(registration?.Object!);
    public static void SetAllowedOrigins(this IComObject<ICoreWebView2CustomSchemeRegistration> registration, IEnumerable<string?> allowedOrigins) => SetAllowedOrigins(registration?.Object!, allowedOrigins);

    public static IReadOnlyList<string?> GetAllowedOrigins(this ICoreWebView2CustomSchemeRegistration registration)
    {
        ArgumentNullException.ThrowIfNull(registration);

        registration.GetAllowedOrigins(out var count, out var array).ThrowOnError();
        var list = new List<string?>((int)count);
        try
        {
            for (var i = 0; i < count; i++)
            {
                var origin = Marshal.ReadIntPtr(array, i * nint.Size);
                list.Add(Marshal.PtrToStringUni(origin));
                Marshal.FreeCoTaskMem(origin);
            }
        }
        finally
        {
            Marshal.FreeCoTaskMem(array);
        }
        return list;
    }

    public static unsafe void SetAllowedOrigins(this ICoreWebView2CustomSchemeRegistration registration, IEnumerable<string?> allowedOrigins)
    {
        ArgumentNullException.ThrowIfNull(registration);
        ArgumentNullException.ThrowIfNull(allowedOrigins);

        var strings = allowedOrigins.Select(o => new DirectN.Extensions.Utilities.Pwstr(o)).ToArray();
        try
        {
            var pointers = strings.Select(s => s.Value).ToArray();
            fixed (nint* pointer = pointers)
            {
                registration.SetAllowedOrigins((uint)pointers.Length, (nint)pointer).ThrowOnError();
            }
        }
        finally
        {
            foreach (var s in strings)
            {
                s.Dispose();
            }
        }
    }
}
