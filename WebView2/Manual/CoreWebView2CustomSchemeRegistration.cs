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

    ~CoreWebView2CustomSchemeRegistration() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        ReplaceAllowedOrigins([]);
    }

    private void ReplaceAllowedOrigins(List<PWSTR> origins)
    {
        var previous = Interlocked.Exchange(ref _allowedOrigins, origins);
        foreach (var origin in previous)
        {
            if (origin.Value != 0)
            {
                Marshal.FreeCoTaskMem(origin.Value);
            }
        }
    }

    private static PWSTR CopyOrigin(string? origin) => origin == null ? PWSTR.Null : new(Marshal.StringToCoTaskMemUni(origin));

    [Obsolete("Use GetAllowedOrigins instead.")]
    public IReadOnlyList<string?> GetAllowedOrgins() => GetAllowedOrigins();

    public IReadOnlyList<string?> GetAllowedOrigins()
    {
        var list = new List<string?>();
        foreach (var origin in _allowedOrigins)
        {
            list.Add(origin.ToString());
        }
        return list;
    }

    public void SetAllowedOrigins(IEnumerable<string?> allowedOrigins)
    {
        ArgumentNullException.ThrowIfNull(allowedOrigins);
        ReplaceAllowedOrigins([.. allowedOrigins.Select(CopyOrigin)]);
    }

    public HRESULT get_HasAuthorityComponent(ref BOOL hasAuthorityComponent) => GetProperty(ref hasAuthorityComponent);
    public HRESULT get_SchemeName(out PWSTR schemeName) => GetProperty(out schemeName);
    public HRESULT get_TreatAsSecure(ref BOOL treatAsSecure) => GetProperty(ref treatAsSecure);
    public HRESULT put_HasAuthorityComponent(BOOL hasAuthorityComponent) => SetProperty(hasAuthorityComponent);
    public HRESULT put_TreatAsSecure(BOOL value) => SetProperty(value);

    public HRESULT SetAllowedOrigins(uint allowedOriginsCount, nint allowedOrigins)
    {
        var list = new List<PWSTR>();
        for (var i = 0; i < allowedOriginsCount; i++)
        {
            list.Add(CopyOrigin(Marshal.PtrToStringUni(Marshal.ReadIntPtr(allowedOrigins, i * nint.Size))));
        }

        ReplaceAllowedOrigins(list);
        return DirectN.Constants.S_OK;
    }

    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAllowedOrigins(out uint allowedOriginsCount, out nint allowedOrigins)
    {
        var origins = _allowedOrigins;
        allowedOriginsCount = (uint)origins.Count;
        allowedOrigins = Marshal.AllocCoTaskMem(nint.Size * origins.Count);
        for (var i = 0; i < origins.Count; i++)
        {
            Marshal.WriteIntPtr(allowedOrigins, i * nint.Size, CopyOrigin(origins[i].ToString()).Value);
        }
        return DirectN.Constants.S_OK;
    }
}
