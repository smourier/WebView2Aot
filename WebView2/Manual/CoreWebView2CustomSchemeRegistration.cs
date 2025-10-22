namespace WebView2;

[GeneratedComClass]
public partial class CoreWebView2CustomSchemeRegistration :
    CoreWebView2ComObject,
    IDisposable,
    ICoreWebView2CustomSchemeRegistration
{
    private List<PWSTR> _allowedOrigins = [];

    public CoreWebView2CustomSchemeRegistration(string schemeName)
    {
        ArgumentNullException.ThrowIfNull(schemeName);
        Properties["SchemeName"] = schemeName;
    }

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Free();
        }
    }

    private void Free()
    {
        var origins = Interlocked.Exchange(ref _allowedOrigins, []);
        foreach (var origin in origins)
        {
            if (origin.Value != 0)
            {
                Marshal.FreeCoTaskMem(origin.Value);
            }
        }
    }

    public IReadOnlyList<string?> GetAllowedOrgins()
    {
        var list = new List<string?>();
        foreach (var origin in _allowedOrigins)
        {
            var str = Marshal.PtrToStringUni(origin.Value);
            list.Add(str);
        }
        return list;
    }

    public unsafe void SetAllowedOrigins(IEnumerable<string?> allowedOrigins)
    {
        ArgumentNullException.ThrowIfNull(allowedOrigins);

        var list = new List<PWSTR>();
        foreach (var allowedOrigin in allowedOrigins)
        {
            if (allowedOrigin == null)
            {
                list.Add(PWSTR.Null);
            }
            else
            {
                list.Add(new(Marshal.StringToCoTaskMemUni(allowedOrigin)));
            }
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
        Free();
        for (var i = 0; i < allowedOriginsCount; i++)
        {
            var ptr = Marshal.ReadIntPtr(allowedOrigins, i * nint.Size);
            _allowedOrigins.Add(new(ptr));
        }
        return DirectN.Constants.S_OK;
    }

    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAllowedOrigins(out uint allowedOriginsCount, out nint allowedOrigins)
    {
        var origins = _allowedOrigins;
        allowedOriginsCount = (uint)origins.Count;
        allowedOrigins = Marshal.AllocHGlobal(nint.Size * origins.Count);
        for (var i = 0; i < origins.Count; i++)
        {
            if (origins[i].Value == 0)
            {
                Marshal.WriteIntPtr(allowedOrigins, i * nint.Size, 0);
            }
            else
            {
                var ptr = Marshal.StringToHGlobalUni(origins[i].ToString());
                Marshal.WriteIntPtr(allowedOrigins, i * nint.Size, ptr);
            }
        }
        return DirectN.Constants.S_OK;
    }
}
