namespace WebView2;

[GeneratedComClass]
public partial class CoreWebView2EnvironmentOptions :
    CoreWebView2ComObject,
    IDisposable,
    ICoreWebView2EnvironmentOptions,
    ICoreWebView2EnvironmentOptions2,
    ICoreWebView2EnvironmentOptions3,
    ICoreWebView2EnvironmentOptions4,
    ICoreWebView2EnvironmentOptions5,
    ICoreWebView2EnvironmentOptions6,
    ICoreWebView2EnvironmentOptions7,
    ICoreWebView2EnvironmentOptions8
{
    private List<nint> _customSchemeRegistrations = [];

    public CoreWebView2EnvironmentOptions()
    {
        Properties["TargetCompatibleBrowserVersion"] = Constants.CORE_WEBVIEW_TARGET_PRODUCT_VERSION;
    }

    public void SetCustomSchemeRegistrations(IEnumerable<CoreWebView2CustomSchemeRegistration> registrations)
    {
        ArgumentNullException.ThrowIfNull(registrations);

        var list = new List<nint>();
        var replaced = false;
        try
        {
            foreach (var registration in registrations)
            {
                var unk = DirectN.Extensions.Com.ComObject.ComWrappers.GetOrCreateComInterfaceForObject(registration, CreateComInterfaceFlags.None);
                try
                {
                    ((HRESULT)Marshal.QueryInterface(unk, typeof(ICoreWebView2CustomSchemeRegistration).GUID, out var ppv)).ThrowOnError();
                    list.Add(ppv);
                }
                finally
                {
                    Marshal.Release(unk);
                }
            }

            ReplaceRegistrations(list);
            replaced = true;
        }
        finally
        {
            if (!replaced)
            {
                ReleaseRegistrations(list);
            }
        }
    }

    ~CoreWebView2EnvironmentOptions() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        ReplaceRegistrations([]);
    }

    private void ReplaceRegistrations(List<nint> registrations) => ReleaseRegistrations(Interlocked.Exchange(ref _customSchemeRegistrations, registrations));

    private static void ReleaseRegistrations(List<nint> registrations)
    {
        foreach (var registration in registrations)
        {
            Marshal.Release(registration);
        }
    }

    public HRESULT get_AdditionalBrowserArguments(out PWSTR value) => GetProperty(out value);
    public HRESULT get_AllowSingleSignOnUsingOSPrimaryAccount(ref BOOL allow) => GetProperty(ref allow);
    public HRESULT get_Language(out PWSTR value) => GetProperty(out value);
    public HRESULT get_TargetCompatibleBrowserVersion(out PWSTR value) => GetProperty(out value);
    public HRESULT put_AdditionalBrowserArguments(PWSTR value) => SetProperty(value);
    public HRESULT put_AllowSingleSignOnUsingOSPrimaryAccount(BOOL allow) => SetProperty(allow);
    public HRESULT put_Language(PWSTR value) => SetProperty(value);
    public HRESULT put_TargetCompatibleBrowserVersion(PWSTR value) => SetProperty(value);

    // ICoreWebView2EnvironmentOptions2
    public HRESULT get_ExclusiveUserDataFolderAccess(ref BOOL value) => GetProperty(ref value);
    public HRESULT put_ExclusiveUserDataFolderAccess(BOOL value) => SetProperty(value);

    // ICoreWebView2EnvironmentOptions3
    public HRESULT get_IsCustomCrashReportingEnabled(ref BOOL value) => GetProperty(ref value);
    public HRESULT put_IsCustomCrashReportingEnabled(BOOL value) => SetProperty(value);

    // ICoreWebView2EnvironmentOptions4
    public unsafe HRESULT GetCustomSchemeRegistrations(out uint count, out nint schemeRegistrations)
    {
        var regs = _customSchemeRegistrations;
        count = (uint)regs.Count;
        var size = sizeof(nint) * regs.Count;
        schemeRegistrations = Marshal.AllocCoTaskMem(size);
        for (var i = 0; i < regs.Count; i++)
        {
            Marshal.AddRef(regs[i]);
            Marshal.WriteIntPtr(schemeRegistrations, i * nint.Size, regs[i]);
        }
        return DirectN.Constants.S_OK;
    }

    public HRESULT SetCustomSchemeRegistrations(uint count, nint schemeRegistrations)
    {
        var list = new List<nint>();
        for (var i = 0; i < count; i++)
        {
            var registration = Marshal.ReadIntPtr(schemeRegistrations, i * nint.Size);
            Marshal.AddRef(registration);
            list.Add(registration);
        }

        ReplaceRegistrations(list);
        return DirectN.Constants.S_OK;
    }

    // ICoreWebView2EnvironmentOptions5
    public HRESULT get_EnableTrackingPrevention(ref BOOL value) => GetProperty(ref value);
    public HRESULT put_EnableTrackingPrevention(BOOL value) => SetProperty(value);

    // ICoreWebView2EnvironmentOptions6
    public HRESULT get_AreBrowserExtensionsEnabled(ref BOOL value) => GetProperty(ref value);
    public HRESULT put_AreBrowserExtensionsEnabled(BOOL value) => SetProperty(value);

    // ICoreWebView2EnvironmentOptions7
    public HRESULT get_ChannelSearchKind(ref COREWEBVIEW2_CHANNEL_SEARCH_KIND value) => GetProperty(ref value);
    public HRESULT put_ChannelSearchKind(COREWEBVIEW2_CHANNEL_SEARCH_KIND value) => SetProperty(value);
    public HRESULT get_ReleaseChannels(ref COREWEBVIEW2_RELEASE_CHANNELS value) => GetProperty(ref value);
    public HRESULT put_ReleaseChannels(COREWEBVIEW2_RELEASE_CHANNELS value) => SetProperty(value);

    // ICoreWebView2EnvironmentOptions8
    public HRESULT get_ScrollBarStyle(ref COREWEBVIEW2_SCROLLBAR_STYLE value) => GetProperty(ref value);
    public HRESULT put_ScrollBarStyle(COREWEBVIEW2_SCROLLBAR_STYLE value) => SetProperty(value);
}
