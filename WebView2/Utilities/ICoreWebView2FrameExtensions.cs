namespace WebView2.Utilities;

public static partial class ICoreWebView2FrameExtensions
{
    public static HRESULT AddHostObjectToScriptWithOrigins(this IComObject<ICoreWebView2Frame> frame, string? name, object hostObject, IEnumerable<string>? origins) => AddHostObjectToScriptWithOrigins(frame?.Object!, name, hostObject, origins);

    public static HRESULT AddHostObjectToScriptWithOrigins(this ICoreWebView2Frame frame, string? name, object hostObject, IEnumerable<string>? origins)
    {
        ArgumentNullException.ThrowIfNull(frame);

        var originStrs = origins?.Select(o => new DirectN.Extensions.Utilities.Pwstr(o)).ToArray() ?? [];
        try
        {
            var pointers = new PWSTR[originStrs.Length + 1];
            for (var i = 0; i < originStrs.Length; i++)
            {
                pointers[i] = originStrs[i];
            }

            using var nameStr = new DirectN.Extensions.Utilities.Pwstr(name);
            return WebView2Utilities.WithHostObjectVariant(hostObject, variant => frame.AddHostObjectToScriptWithOrigins(nameStr, ref variant.RefDetached, (uint)originStrs.Length, in pointers[0]));
        }
        finally
        {
            foreach (var originStr in originStrs)
            {
                originStr.Dispose();
            }
        }
    }
}
