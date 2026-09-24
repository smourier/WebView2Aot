namespace WebView2.Utilities;

public static partial class ICoreWebView2EnvironmentOptions4Extensions
{
    public static IReadOnlyList<IComObject<ICoreWebView2CustomSchemeRegistration>> GetCustomSchemeRegistrations(this IComObject<ICoreWebView2EnvironmentOptions4> options) => GetCustomSchemeRegistrations(options?.Object!);
    public static void SetCustomSchemeRegistrations(this IComObject<ICoreWebView2EnvironmentOptions4> options, IEnumerable<ICoreWebView2CustomSchemeRegistration> registrations) => SetCustomSchemeRegistrations(options?.Object!, registrations);

    public static IReadOnlyList<IComObject<ICoreWebView2CustomSchemeRegistration>> GetCustomSchemeRegistrations(this ICoreWebView2EnvironmentOptions4 options)
    {
        ArgumentNullException.ThrowIfNull(options);

        options.GetCustomSchemeRegistrations(out var count, out var array).ThrowOnError();
        var list = new List<IComObject<ICoreWebView2CustomSchemeRegistration>>((int)count);
        try
        {
            for (var i = 0; i < count; i++)
            {
                var registration = DirectN.Extensions.Com.ComObject.FromPointer<ICoreWebView2CustomSchemeRegistration>(Marshal.ReadIntPtr(array, i * nint.Size));
                if (registration != null)
                {
                    list.Add(registration);
                }
            }
        }
        finally
        {
            Marshal.FreeCoTaskMem(array);
        }
        return list;
    }

    public static unsafe void SetCustomSchemeRegistrations(this ICoreWebView2EnvironmentOptions4 options, IEnumerable<ICoreWebView2CustomSchemeRegistration> registrations)
    {
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(registrations);

        var unknowns = new List<nint>();
        try
        {
            foreach (var registration in registrations)
            {
                unknowns.Add(DirectN.Extensions.Com.ComObject.GetOrCreateComInstance<ICoreWebView2CustomSchemeRegistration>(registration, throwOnError: true));
            }

            var array = unknowns.ToArray();
            fixed (nint* pointer = array)
            {
                options.SetCustomSchemeRegistrations((uint)array.Length, (nint)pointer).ThrowOnError();
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
