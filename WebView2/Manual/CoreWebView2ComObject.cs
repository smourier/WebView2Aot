namespace WebView2;

public abstract class CoreWebView2ComObject
{
    private readonly Dictionary<string, object?> _properties = [];

    protected IDictionary<string, object?> Properties => _properties;

    protected virtual HRESULT SetProperty(PWSTR value, [CallerMemberName] string? name = null) => SetProperty(value.ToString(), name);
    protected virtual HRESULT SetProperty<T>(T value, [CallerMemberName] string? name = null)
    {
        name = NormalizePropertyName(name!);
        _properties[name] = value;
        return DirectN.Constants.S_OK;
    }

    protected virtual HRESULT GetProperty(out PWSTR value, [CallerMemberName] string? name = null)
    {
        name = NormalizePropertyName(name!);
        if (_properties.TryGetValue(name, out var obj) && obj is string s)
        {
            value = new(Marshal.StringToCoTaskMemUni(s));
            return DirectN.Constants.S_OK;
        }

        value = PWSTR.Null;
        return DirectN.Constants.S_OK;
    }

    protected virtual HRESULT GetProperty<T>(ref T value, [CallerMemberName] string? name = null)
    {
        name = NormalizePropertyName(name!);
        if (_properties.TryGetValue(name, out var obj) && obj is T t)
        {
            value = t;
            return DirectN.Constants.S_OK;
        }

        value = default!;
        return DirectN.Constants.S_OK;
    }

    private static string NormalizePropertyName(string name) => name.StartsWith("get_") || name.StartsWith("put_") ? name[4..] : name;
}
