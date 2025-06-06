﻿#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("d60ac92c-37a6-4b26-a39e-95cfe59047bb")]
public partial interface ICoreWebView2CustomSchemeRegistration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SchemeName(ref PWSTR schemeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TreatAsSecure(ref BOOL treatAsSecure);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TreatAsSecure(BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllowedOrigins(ref uint allowedOriginsCount, ref PWSTR allowedOrigins);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllowedOrigins(uint allowedOriginsCount, in PWSTR allowedOrigins);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HasAuthorityComponent(ref BOOL hasAuthorityComponent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HasAuthorityComponent(BOOL hasAuthorityComponent);
}
