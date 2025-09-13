#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("76eceacb-0462-4d94-ac83-423a6793775e")]
public partial interface ICoreWebView2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Settings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2Settings>))] out ICoreWebView2Settings settings);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Source(out PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Navigate(PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NavigateToString(PWSTR htmlContent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NavigationStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationStartingEventHandler>))] ICoreWebView2NavigationStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NavigationStarting(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ContentLoading([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContentLoadingEventHandler>))] ICoreWebView2ContentLoadingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ContentLoading(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_SourceChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2SourceChangedEventHandler>))] ICoreWebView2SourceChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_SourceChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_HistoryChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2HistoryChangedEventHandler>))] ICoreWebView2HistoryChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_HistoryChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NavigationCompleted([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationCompletedEventHandler>))] ICoreWebView2NavigationCompletedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NavigationCompleted(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_FrameNavigationStarting([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationStartingEventHandler>))] ICoreWebView2NavigationStartingEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_FrameNavigationStarting(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_FrameNavigationCompleted([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NavigationCompletedEventHandler>))] ICoreWebView2NavigationCompletedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_FrameNavigationCompleted(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ScriptDialogOpening([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ScriptDialogOpeningEventHandler>))] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ScriptDialogOpening(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_PermissionRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2PermissionRequestedEventHandler>))] ICoreWebView2PermissionRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_PermissionRequested(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ProcessFailed([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ProcessFailedEventHandler>))] ICoreWebView2ProcessFailedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ProcessFailed(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddScriptToExecuteOnDocumentCreated(PWSTR javaScript, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler>))] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveScriptToExecuteOnDocumentCreated(PWSTR id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ExecuteScript(PWSTR javaScript, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ExecuteScriptCompletedHandler>))] ICoreWebView2ExecuteScriptCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CapturePreview(COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, IStream imageStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CapturePreviewCompletedHandler>))] ICoreWebView2CapturePreviewCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reload();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsJson(PWSTR webMessageAsJson);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostWebMessageAsString(PWSTR webMessageAsString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WebMessageReceived([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebMessageReceivedEventHandler>))] ICoreWebView2WebMessageReceivedEventHandler handler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_WebMessageReceived(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CallDevToolsProtocolMethod(PWSTR methodName, PWSTR parametersAsJson, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2CallDevToolsProtocolMethodCompletedHandler>))] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BrowserProcessId(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CanGoBack(ref BOOL canGoBack);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CanGoForward(ref BOOL canGoForward);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoBack();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoForward();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevToolsProtocolEventReceiver(PWSTR eventName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DevToolsProtocolEventReceiver>))] out ICoreWebView2DevToolsProtocolEventReceiver receiver);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_NewWindowRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2NewWindowRequestedEventHandler>))] ICoreWebView2NewWindowRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_NewWindowRequested(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_DocumentTitleChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2DocumentTitleChangedEventHandler>))] ICoreWebView2DocumentTitleChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_DocumentTitleChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DocumentTitle(out PWSTR title);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddHostObjectToScript(PWSTR name, ref VARIANT @object);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveHostObjectFromScript(PWSTR name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenDevToolsWindow();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ContainsFullScreenElementChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2ContainsFullScreenElementChangedEventHandler>))] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ContainsFullScreenElementChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContainsFullScreenElement(ref BOOL containsFullScreenElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WebResourceRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WebResourceRequestedEventHandler>))] ICoreWebView2WebResourceRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_WebResourceRequested(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddWebResourceRequestedFilter(PWSTR uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveWebResourceRequestedFilter(PWSTR uri, COREWEBVIEW2_WEB_RESOURCE_CONTEXT resourceContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_WindowCloseRequested([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2WindowCloseRequestedEventHandler>))] ICoreWebView2WindowCloseRequestedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_WindowCloseRequested(EventRegistrationToken token);
}
