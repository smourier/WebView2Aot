namespace WebView2.Utilities;

public static class WebView2Utilities
{
    public const string LoaderDllName = "WebView2Loader";

    private const uint ERROR_MOD_NOT_FOUND = 0x8007007E;

    public static HRESULT Initialize(bool throwOnError = true)
    {
        var hr = Initialize();
        if (hr == ERROR_MOD_NOT_FOUND && throwOnError)
            throw new Exception($"Cannot load {LoaderDllName}.dll. Make sure it's present in the current's process path.");

        hr.ThrowOnError(throwOnError);
        return hr;
    }

    private static HRESULT Initialize()
    {
        string? firstPath = null;
        foreach (var path in PossiblePaths)
        {
            firstPath ??= path;
            var h = DirectN.Functions.LoadLibraryW(PWSTR.From(path));
            if (h.Value != 0)
                return 0;
        }

        if (firstPath == null)
            return ERROR_MOD_NOT_FOUND;

        DirectN.Functions.LoadLibraryW(PWSTR.From(firstPath));
        return Marshal.GetHRForLastWin32Error();
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
