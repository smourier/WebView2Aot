#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("a3ec0f5f-ddbc-54ed-8546-af75a785b9a6")]
public partial interface ICoreWebView2Find
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActiveMatchIndex(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MatchCount(ref int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_ActiveMatchIndexChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FindActiveMatchIndexChangedEventHandler>))] ICoreWebView2FindActiveMatchIndexChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_ActiveMatchIndexChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add_MatchCountChanged([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FindMatchCountChangedEventHandler>))] ICoreWebView2FindMatchCountChangedEventHandler eventHandler, ref EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove_MatchCountChanged(EventRegistrationToken token);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FindOptions>))] ICoreWebView2FindOptions options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICoreWebView2FindStartCompletedHandler>))] ICoreWebView2FindStartCompletedHandler handler);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindNext();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindPrevious();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
}
