namespace ScriptHostObjectWebView2;

// An host object for the WebView2 control must implement IDispatch.
// When we have say, this in javascript:
//
//         var options = JSON.parse(chrome.webview.hostObjects.dotnet.getInfo());
//
// 'dotnet' corresponds to this instance
#pragma warning disable CA1822 // Mark members as static
[GeneratedComClass]
public partial class HostObject : DispatchObject
{
    public event EventHandler<string>? ClockTick;

    public string GetInfo()
    {
        var info = new HostObjectInfo();
        return JsonSerializer.Serialize(info, JsonSourceGenerationContext.Default.HostObjectInfo);
    }

    public Task<string> GetInfoAsync(int delay) => Task.Run(async () =>
    {
        await Task.Delay(delay).ConfigureAwait(false); // simulate some async work
        return GetInfo();
    });

    public void OnClockTick(string date) => ClockTick?.Invoke(this, date);

    // note this is necessary to avoid trimming Task<T>.Result (for some given T) for AOT publishing
    // all Task<T> results must be unwrapped here, so you can return any type you want
    protected override object? GetTaskResult(Task task)
    {
        if (task is Task<string> s)
            return s.Result;

        return null;
    }
}
#pragma warning restore CA1822 // Mark members as static
