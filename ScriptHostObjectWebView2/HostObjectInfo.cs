namespace ScriptHostObjectWebView2;

public class HostObjectInfo
{
    public string FileVersion => AssemblyUtilities.GetFileVersion()!;
    public string OSVersion => Environment.OSVersion.ToString();
    public string DotNetVersion => Environment.Version.ToString();
}
