using System.Security.Cryptography;
using System.Text;

namespace WebView2.Utilities;

public static class WebView2Utilities
{
    public const string LoaderDllName = "WebView2Loader";

    public static bool IsInitialized { get; private set; }
    public static bool IsRunningViaDotnet { get; } = RunningViaDotnet();
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

    // assembly can be present as files in current directory or in assemblies embedded resources
    public static HRESULT Initialize(Assembly? assembly = null, bool throwOnError = true)
    {
        if (IsInitialized)
            return DirectN.Constants.S_OK;

        var hr = Initialize(assembly);
        if (hr == DirectN.Constants.ERROR_MOD_NOT_FOUND && throwOnError)
            throw new Exception($"Cannot load {LoaderDllName}.dll. Make sure it's present in the current's process path.");

        hr.ThrowOnError(throwOnError);
        IsInitialized = hr.IsSuccess;
        return hr;
    }

    // supports apps ran as dotnet <myapp.dll>
    [UnconditionalSuppressMessage("SingleFile", "IL3000:Avoid accessing Assembly file path when publishing as a single file", Justification = "Used only if launched via dotnet.exe")]
    public static string? GetDefaultUserDataFolder()
    {
        if (!IsRunningViaDotnet)
            return null;

        // https://learn.microsoft.com/en-us/microsoft-edge/webview2/reference/win32/webview2-idl
        // mimic default {Executable File Name}.WebView2 if we can
        var entry = Assembly.GetEntryAssembly()?.Location;
        if (entry == null)
            return Environment.CurrentDirectory;

        return Path.Combine(Environment.CurrentDirectory, Path.GetFileNameWithoutExtension(entry) + ".exe.WebView2");
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
            return DirectN.Constants.ERROR_MOD_NOT_FOUND;

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

            string? processDir;
            if (IsRunningViaDotnet)
            {
                // this case process path will be somewhere like programfiles\dotnet.exe
                processDir = Environment.CurrentDirectory;
            }
            else
            {
                processDir = Path.GetDirectoryName(Environment.ProcessPath);
            }
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

    private static bool RunningViaDotnet()
    {
        try
        {
            var path = Environment.ProcessPath;
            if (path == null || !Path.GetFileName(path).Equals("dotnet.exe", StringComparison.OrdinalIgnoreCase))
                return false;

            var dir = Path.GetDirectoryName(path);
            if (dir is null)
                return false;

            return isChildOf(RuntimeEnvironment.GetRuntimeDirectory(), dir);
            static bool isChildOf(string path, string parent)
            {
                if (string.Equals(path, parent, StringComparison.OrdinalIgnoreCase))
                    return true;

                var dir = Path.GetDirectoryName(path);
                return dir != null && isChildOf(dir, parent);
            }
        }
        catch
        {
            // continue
            return false;
        }
    }
}
