namespace WebView2;

[GeneratedComClass]
public partial class CoreWebView2CustomSchemeRegistration :
    CoreWebView2ComObject,
    ICoreWebView2CustomSchemeRegistration
{
    private List<string> _allowedOrigins = [];

    public CoreWebView2CustomSchemeRegistration(string schemeName)
    {
        ArgumentNullException.ThrowIfNull(schemeName);
        Properties["SchemeName"] = schemeName;
    }

    public IReadOnlyList<string> GetAllowedOrgins() => _allowedOrigins.AsReadOnly();
    public unsafe void SetAllowedOrigins(IEnumerable<string> allowedOrigins)
    {
        ArgumentNullException.ThrowIfNull(allowedOrigins);

        var list = new List<PWSTR>();
        foreach (var allowedOrigin in allowedOrigins)
        {
            list.Add(new(Marshal.StringToCoTaskMemUni(allowedOrigin)));
        }

        var array = list.ToArray();
        var arrayPointer = (nint)Unsafe.AsPointer(ref MemoryMarshal.GetArrayDataReference(array));
        SetAllowedOrigins((uint)array.Length, arrayPointer);
    }

    public HRESULT get_HasAuthorityComponent(ref BOOL hasAuthorityComponent) => GetProperty(ref hasAuthorityComponent);
    public HRESULT get_SchemeName(out PWSTR schemeName) => GetProperty(out schemeName);
    public HRESULT get_TreatAsSecure(ref BOOL treatAsSecure) => GetProperty(ref treatAsSecure);
    public HRESULT put_HasAuthorityComponent(BOOL hasAuthorityComponent) => SetProperty(hasAuthorityComponent);
    public HRESULT put_TreatAsSecure(BOOL value) => SetProperty(value);

    public HRESULT SetAllowedOrigins(uint allowedOriginsCount, nint allowedOrigins)
    {
        var regs = Interlocked.Exchange(ref _allowedOrigins, []);
        for (var i = 0; i < allowedOriginsCount; i++)
        {
            var ptr = Marshal.ReadIntPtr(allowedOrigins, i * IntPtr.Size);
            if (ptr == 0)
                continue;

            var origin = Marshal.PtrToStringUni(ptr);
            if (origin != null)
            {
                regs.Add(origin);
            }
        }
        return DirectN.Constants.S_OK;
    }

    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAllowedOrigins(out uint allowedOriginsCount, out nint allowedOrigins)
    {
        var origins = _allowedOrigins;
        allowedOriginsCount = (uint)origins.Count;
        allowedOrigins = Marshal.AllocHGlobal(IntPtr.Size * origins.Count);
        for (var i = 0; i < origins.Count; i++)
        {
            var ptr = Marshal.StringToHGlobalUni(origins[i]);
            Marshal.WriteIntPtr(allowedOrigins, i * IntPtr.Size, ptr);
        }
        return DirectN.Constants.S_OK;
    }
}
