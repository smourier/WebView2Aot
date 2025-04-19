# WebView2Aot
[Microsoft WebView2](https://developer.microsoft.com/en-us/microsoft-edge/webview2?form=MA13LH) .NET 9+ AOT-compatible bindings 100% independent from WinForms or WPF.

* **HelloWebView2** is a sample hello world in 40 lignes of C# code (see screenshot below).
* **WebView2** is the .NET Core 9+ AOT-compatible bindings dll that can be used to use WebView2.
* **WebView2Aot.InteropBuilder.Cli** is the tool that generates code in the WebView2 dll. This is based on the linked [Win32InteropBuilder](https://github.com/smourier/Win32InteropBuilder) generic project. It also needs Microsoft.Web.WebView2.Win32.winmd which is the WebView2 metadata (check this for more information https://github.com/wravery/webview2-win32md).

WebView2 has a dependency to  [DirectN AOT](https://github.com/smourier/DirectNAot) for some Windows definitions (BOOL, PWSTR, etc.) but has zero dependency on any UI framework.

**Note**: for deployment, you can reference the standard [Microsoft.Web.WebView2 ](https://www.nuget.org/packages/microsoft.web.webview2) nuget package however, it comes with all pre-built WPF & Winforms NET dll and xml, while we only need the native *WebView2Loader.dll* file, so you can extract this file corresponding to your processor architecture (x86, x64, arm4), it that rarely changes, and put it locally in your folder (or check how it's done in HelloWebView2).

# HelloWebView2
![image](https://github.com/user-attachments/assets/885a9167-885a-435e-ad5b-2b4e91ae610c)
