using System.Security.Cryptography;
using System.Text;

namespace WebView2.Utilities;

public static class WebView2Utilities
{
    public const string LoaderDllName = "WebView2Loader";

    private const uint ERROR_MOD_NOT_FOUND = 0x8007007E;
    private static bool _initialized;

    public static COREWEBVIEW2_COLOR GetColor(this D3DCOLORVALUE color) => new() { A = color.BA, R = color.BR, G = color.BG, B = color.BB };
    public static D3DCOLORVALUE FromColor(this COREWEBVIEW2_COLOR color) => new() { BA = color.A, BR = color.R, BG = color.G, BB = color.B };

    // returns null if webview2 is not installed in executable folder
    public static string? GetAvailableCoreWebView2BrowserVersionString(string? browserExecutableFolder = null)
    {
        Functions.GetAvailableCoreWebView2BrowserVersionString(PWSTR.From(browserExecutableFolder), out var p);
        var versionInfo = p.ToString();
        if (p.Value != 0)
        {
            Marshal.FreeCoTaskMem(p.Value);
        }
        return versionInfo;
    }

    // assembly can be present in files or in assemblies embedded resources
    public static HRESULT Initialize(Assembly? assembly = null, bool throwOnError = true)
    {
        if (_initialized)
            return DirectN.Constants.S_OK;

        var hr = Initialize(assembly);
        if (hr == ERROR_MOD_NOT_FOUND && throwOnError)
            throw new Exception($"Cannot load {LoaderDllName}.dll. Make sure it's present in the current's process path.");

        hr.ThrowOnError(throwOnError);
        _initialized = hr.IsSuccess;
        return hr;
    }

    private static HRESULT Initialize(Assembly? assembly)
    {
        HMODULE h;
        if (assembly != null)
        {
            var asmPath = GetWebLoaderPathFromAssemblyResources(assembly);
            if (asmPath != null)
            {
                h = DirectN.Functions.LoadLibraryW(PWSTR.From(asmPath));
                if (h.Value != 0)
                    return DirectN.Constants.S_OK;

                return Marshal.GetHRForLastWin32Error();
            }
        }

        string? firstPath = null;
        foreach (var path in PossiblePaths)
        {
            firstPath ??= path;
            h = DirectN.Functions.LoadLibraryW(PWSTR.From(path));
            if (h.Value != 0)
                return DirectN.Constants.S_OK;
        }

        if (firstPath == null)
            return ERROR_MOD_NOT_FOUND;

        h = DirectN.Functions.LoadLibraryW(PWSTR.From(firstPath));
        if (h.Value != 0)
            return DirectN.Constants.S_OK;

        return Marshal.GetHRForLastWin32Error();
    }

    private static string? GetWebLoaderPathFromAssemblyResources(Assembly assembly)
    {
        var arch = RuntimeInformation.ProcessArchitecture.ToString();
        var names = assembly.GetManifestResourceNames();

        var dllName = LoaderDllName + ".dll";
        // first check with arch
        var name = names.FirstOrDefault(n => n.Contains(arch, StringComparison.OrdinalIgnoreCase) && n.EndsWith(dllName, StringComparison.OrdinalIgnoreCase));
        if (name == null)
        {
            // fallback to any that's not arch specific
            var allArchs = new[] { "x86", "x64", "arm64" };
            name = names.FirstOrDefault(n => allArchs.All(a => !n.Contains(a)) && n.EndsWith(dllName, StringComparison.OrdinalIgnoreCase));
        }
        if (name == null)
            return null;

        // come up with some local unique temp dir
        var key = $"{assembly.FullName}, {name}";
        var id = new Guid(MD5.HashData(Encoding.UTF8.GetBytes(key)));
        var tempPath = Path.Combine(Path.GetTempPath(), id.ToString(), dllName);
        using var stream = assembly.GetManifestResourceStream(name);
        if (stream == null || stream.Length < 512) // bug of some sort
            return null;

        var fi = new FileInfo(tempPath);
        if (!fi.Exists || fi.Length != stream.Length)
        {
            var dir = Path.GetDirectoryName(tempPath)!;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            using var file = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.None);
            stream.CopyTo(file);
        }
        return tempPath;
    }

    private static IEnumerable<string> PossiblePaths
    {
        get
        {
            if (Environment.ProcessPath == null)
                yield break;

            var processDir = Path.GetDirectoryName(Environment.ProcessPath);
            if (processDir == null)
                yield break;

            var name = LoaderDllName + ".dll";
            var path = Path.Combine(processDir, name);
            if (File.Exists(path))
                yield return path;

            var arch = RuntimeInformation.ProcessArchitecture;
            switch (arch)
            {
                case Architecture.Arm64:
                case Architecture.X64:
                case Architecture.X86:
                    path = Path.Combine(processDir, "runtimes", "win-" + arch.ToString().ToLowerInvariant(), "native", name);
                    if (File.Exists(path))
                        yield return path;

                    break;
            }
        }
    }
}
