namespace ScriptHostObjectWebView2;

#pragma warning disable CA1822 // Mark members as static
public class HostObjectInfo
{
    public string FileVersion => AssemblyUtilities.GetFileVersion()!;
    public string OSVersion => Environment.OSVersion.ToString();
    public string DotNetVersion => Environment.Version.ToString();
}
#pragma warning restore CA1822 // Mark members as static
