namespace MarkdownViewer;

public partial class Main : Form
{
    private static readonly string _title = DirectN.Extensions.Utilities.AssemblyUtilities.GetTitle() ?? "Markdown Viewer";

    private static readonly IReadOnlyList<string> _extensions =
    [
        "*.md",
        "*.markdown",
        "*.mmd",
        "*.mkd",
        "*.mdwn",
        "*.mdown",
        "*.mdtxt",
        "*.mdtext",
        "*.markdown",
        "*.text",
    ];

    private static readonly MarkdownPipeline _pipeline = new MarkdownPipelineBuilder().
        UseAdvancedExtensions().
        UseEmojiAndSmiley().
        Build();

    private readonly HostObject _hostObject = new();
    private ComObject<ICoreWebView2Controller>? _controller;
    private ComObject<ICoreWebView2>? _webView;
    private readonly string? _firstArg;

    public Main()
    {
        _firstArg = DirectN.Extensions.Utilities.CommandLine.Current.GetNullifiedArgument(0);
        try
        {
            if (_firstArg != null && !new FileInfo(_firstArg).Exists)
            {
                _firstArg = null;
            }
        }
        catch
        {
            // continue
            _firstArg = null;
        }

        InitializeComponent();
        AllowDrop = true;

        // note: d&d only works on caption bar as we disable it in the webview (and it would be tricky to re-enable it there)
        DragDrop += OnDragDrop;
        DragEnter += OnDragEnter;

        Text = _title;
        StartPosition = FormStartPosition.CenterScreen;
        var img = DirectN.Extensions.Utilities.Icon.LoadApplicationIcon()?.Handle;
        if (img != null)
        {
            Icon = Icon.FromHandle(img.Value);
        }
        Size = new Size(300, 450);
        MinimumSize = Size;

        _hostObject.Opening += (s, e) =>
        {
            if (e.FilePath != null)
            {
                e.Html = DoOpen(e.FilePath);
                return;
            }

            var ofd = new OpenFileDialog
            {
                Title = "Open Markdown File",
                Filter = $"Markdown Files|{string.Join(';', _extensions)}| All Files|*.*",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            e.Html = DoOpen(ofd.FileName);
        };

        _hostObject.Ready += (s, e) =>
        {
            if (_firstArg != null)
            {
                Open(_firstArg);
            }
        };

        _hostObject.Closing += (s, e) =>
        {
            Size = MinimumSize;
            CenterToScreen();
        };

        _hostObject.Associating += (s, e) =>
        {
            if (DirectN.Extensions.Utilities.SystemUtilities.GetTokenElevationType() == DirectN.Extensions.Utilities.TokenElevationType.Limited)
            {
                Register(Registry.CurrentUser);
            }
            else
            {
                Register(Registry.LocalMachine);
            }
        };

        _hostObject.Dissociating += (s, e) =>
        {
            if (DirectN.Extensions.Utilities.SystemUtilities.GetTokenElevationType() == DirectN.Extensions.Utilities.TokenElevationType.Limited)
            {
                Unregister(Registry.CurrentUser);
            }
            else
            {
                Unregister(Registry.LocalMachine);
            }
        };
    }

    private void OnDragEnter(object? sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
        {
            e.Effect = DragDropEffects.Copy;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }

    private void OnDragDrop(object? sender, DragEventArgs e)
    {
        if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true && e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
        {
            Open(files[0]);
        }
    }

    public void Open(string filePath)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(filePath);
            ExecuteScript($"loadFromFile(\"{HttpUtility.JavaScriptStringEncode(filePath)}\");").ThrowOnError();
        }
        catch (Exception ex)
        {
            ShowError($"An error has occurred trying to open '{filePath}'", ex);
            Size = MinimumSize;
        }
    }

    private void ShowError(string text, Exception ex)
    {
        DirectN.Extensions.Utilities.Application.TraceError(text + ": " + ex);
        var page = new TaskDialogPage()
        {
            AllowCancel = false,
            AllowMinimize = false,
            Heading = text,
            Text = DirectN.Extensions.Utilities.Extensions.GetAllMessages(ex, "."),
            Icon = TaskDialogIcon.Error,

        };
        TaskDialog.ShowDialog(this, page);
    }

    private void SetSize()
    {
        // resize to 3/4 of the current screen
        var screen = Screen.FromControl(this).WorkingArea;
        Size = new Size(screen.Width * 3 / 4, screen.Height * 3 / 4);
        CenterToScreen();
    }

    internal string? DoOpen(string filePath)
    {
        ArgumentNullException.ThrowIfNull(filePath);

        string html;
        try
        {
            using var sw = new StreamReader(filePath);
            var text = sw.ReadToEnd();
            html = Markdown.ToHtml(text, _pipeline);
            Text = _title;
            ExecuteScript($"setBase(\"{HttpUtility.JavaScriptStringEncode($@"{Path.GetDirectoryName(filePath)}\")}\");").ThrowOnError();
        }
        catch (Exception ex)
        {
            ShowError($"An error has occurred trying to load '{filePath}'", ex);
            Size = MinimumSize;
            return null;
        }

        SetSize();
        Text = $"{_title} - {filePath}";
        return html;
    }

    private static IEnumerable<string> GetProgIds() => _extensions.Select(e => $"{Program.AppId}.{e.TrimStart(['*', '.'])}");

    public void Register(RegistryKey key)
    {
        ArgumentNullException.ThrowIfNull(key);

        try
        {
            foreach (var progid in GetProgIds())
            {
                using var progidKey = key.EnsureSubKey($@"Software\Classes\{progid}");
                if (progidKey != null)
                {
                    progidKey.SetValue(null, "Markdown Document");

                    using var defaultIconKey = progidKey.EnsureSubKey("DefaultIcon");
                    defaultIconKey?.SetValue(null, $"{Environment.ProcessPath},0");

                    using var shellKey = progidKey.EnsureSubKey(@"shell\open\command");
                    shellKey?.SetValue(null, $"{Environment.ProcessPath} \"%1\"");
                }

                if (_title != null)
                {
                    using var shellOpen = key.EnsureSubKey($@"Software\Classes\{progid}\shell\open");
                    shellOpen?.SetValue("FriendlyAppName", _title);
                }
            }

            using var md = key.EnsureSubKey($@"Software\Classes\.md\OpenWithProgids");
            md?.SetValue($"{Program.AppId}.md", string.Empty);

            var page = new TaskDialogPage()
            {
                AllowCancel = false,
                AllowMinimize = false,
                Heading = $"Registration to the Shell succeeded, 'Open With' command can be used with {_title}",
                Icon = TaskDialogIcon.Information,

            };
            TaskDialog.ShowDialog(this, page);
        }
        catch (Exception ex)
        {
            ShowError($"An error has occurred trying to register to the Shell", ex);
            return;
        }
    }

    public void Unregister(RegistryKey key)
    {
        ArgumentNullException.ThrowIfNull(key);

        try
        {
            foreach (var progid in GetProgIds())
            {
                key.DeleteSubKeyTree($@"Software\Classes\{progid}", false);
            }

            using var md = key.OpenSubKey($@"Software\Classes\.md\OpenWithProgids", true);
            md?.DeleteValue($"{Program.AppId}.md", false);

            var page = new TaskDialogPage()
            {
                AllowCancel = false,
                AllowMinimize = false,
                Heading = $"Unregistration from the Shell succeeded",
                Icon = TaskDialogIcon.Information,

            };
            TaskDialog.ShowDialog(this, page);
        }
        catch (Exception ex)
        {
            ShowError($"An error has occurred trying to unregister from the Shell", ex);
            return;
        }
    }

    protected override void CreateHandle()
    {
        base.CreateHandle();

        if (_firstArg != null)
        {
            SetSize();
        }

        // store user data in local app data folder unless overridden on command line
        var appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), typeof(Program).Namespace!);
        var userDataFolder = DirectN.Extensions.Utilities.CommandLine.Current.GetNullifiedArgument("udf", Path.Combine(appFolder, "WebView2"));

        WebView2.Functions.CreateCoreWebView2EnvironmentWithOptions(PWSTR.Null, PWSTR.From(userDataFolder), null!,
        new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler((result, env) =>
        {
            env.CreateCoreWebView2Controller(Handle, new CoreWebView2CreateCoreWebView2ControllerCompletedHandler((result, controller) =>
            {
                _controller = new ComObject<ICoreWebView2Controller>(controller);

                SizeChange();
                controller.get_CoreWebView2(out var webView2).ThrowOnError();
                _webView = new ComObject<ICoreWebView2>(webView2);

                webView2.get_Settings(out var settingsObj).ThrowOnError();
                using var settings = new ComObject<ICoreWebView2Settings3>(settingsObj);
                settingsObj.put_IsBuiltInErrorPageEnabled(false).ThrowOnError();
                settingsObj.put_AreDefaultContextMenusEnabled(false);
                settingsObj.put_IsStatusBarEnabled(false).ThrowOnError();
                settings.Object.put_AreBrowserAcceleratorKeysEnabled(false).ThrowOnError();

#if DEBUG
                webView2.OpenDevToolsWindow();
#endif

                // get IUnknown from the host object and wrap it in a VARIANT
                ComObject.WithComInstance(_hostObject, unk =>
                {
                    using var variant = new DirectN.Extensions.Utilities.Variant(unk, VARENUM.VT_UNKNOWN);
                    var detached = variant.Detached;
                    webView2.AddHostObjectToScript(PWSTR.From("dotnet"), ref detached).ThrowOnError();
                }, true);

                // load index.html from the current assembly
                var html = Encoding.UTF8.GetString(DirectN.Extensions.Utilities.Extensions.LoadFromResource(Assembly.GetExecutingAssembly(), GetType().Namespace + ".Index.html"));

                // check we have a cached version
                var cachedPath = Path.Combine(appFolder, Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "1.0.0.0", "index.html");
                var fi = new FileInfo(cachedPath);
#if DEBUG
                Directory.CreateDirectory(fi.DirectoryName!);
                File.WriteAllText(cachedPath, html, Encoding.UTF8);
#else
                if (!fi.Exists || fi.Length < 64)
                {
                    Directory.CreateDirectory(fi.DirectoryName!);
                    File.WriteAllText(cachedPath, html, Encoding.UTF8);
                }
#endif

                webView2.Navigate(PWSTR.From(cachedPath));
                FocusChange();
            }));
        }));
    }

    private void SizeChange() => _controller?.Object.put_Bounds(RECT.Sized(0, 0, ClientRectangle.Width, ClientRectangle.Height)).ThrowOnError();
    private void FocusChange() => _controller?.Object.MoveFocus(COREWEBVIEW2_MOVE_FOCUS_REASON.COREWEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC);
    protected override void OnGotFocus(EventArgs e) => FocusChange();
    protected override void OnLostFocus(EventArgs e) => FocusChange();
    protected override void OnSizeChanged(EventArgs e) => SizeChange();

    public virtual Task<T?> ExecuteScript<T>(string script, JsonTypeInfo<T> typeInfo, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(script);
        var webView = _webView ?? throw new InvalidOperationException();
        return webView.Object.ExecuteScript(script, typeInfo, throwOnError: throwOnError);
    }

    public virtual Task<string?> ExecuteScriptAsJson(string script, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(script);
        var webView = _webView ?? throw new InvalidOperationException();
        return webView.Object.ExecuteScriptAsJon(script, throwOnError: throwOnError);
    }

    public virtual HRESULT ExecuteScript(string script, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(script);
        var webView = _webView ?? throw new InvalidOperationException();
        return webView.Object.ExecuteScript(PWSTR.From(script), new CoreWebView2ExecuteScriptCompletedHandler((error, result) =>
        {
        })).ThrowOnError(throwOnError);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Interlocked.Exchange(ref _webView, null)?.Dispose();
            Interlocked.Exchange(ref _controller, null)?.Dispose();
            components?.Dispose();
        }
        base.Dispose(disposing);
    }

}
