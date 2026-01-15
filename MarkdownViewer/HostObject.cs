using System.Runtime.InteropServices.Marshalling;

namespace MarkdownViewer;

// An host object for the WebView2 control must implement IDispatch.
// When we have say, this in javascript:
//
//         var options = JSON.parse(chrome.webview.hostObjects.dotnet.getInfo());
//
// 'dotnet' corresponds to this instance
[GeneratedComClass]
public partial class HostObject : DispatchObject
{
    public event EventHandler<OpeningEventArgs>? Opening;
    public event EventHandler? Closing;
    public event EventHandler? Associating;
    public event EventHandler? Dissociating;
    public event EventHandler? Ready;

    public string? Open(string? filePath)
    {
        var e = new OpeningEventArgs(filePath);
        Opening?.Invoke(this, e);
        return e.Html;
    }

    public void NotifyReady() => Ready?.Invoke(this, EventArgs.Empty);
    public void Close() => Closing?.Invoke(this, EventArgs.Empty);
    public void Associate() => Associating?.Invoke(this, EventArgs.Empty);
    public void Dissociate() => Dissociating?.Invoke(this, EventArgs.Empty);

#pragma warning disable CA1822 // Mark members as static
    public string GetCloseIcon()
    {
        using var icon = SystemIcons.GetStockIcon(StockIconId.Delete);
        using var bmp = icon.ToBitmap();
        using var ms = new MemoryStream();
        bmp.Save(ms, ImageFormat.Png);
        return "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
    }

    public bool IsWindows10OrGreater() => Environment.OSVersion.Version.Major >= 10;
#pragma warning restore CA1822 // Mark members as static
}
