﻿#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("054dae00-84a3-49ff-bc17-4012a90bc9fd")]
public partial interface ICoreWebView2ScriptException
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LineNumber(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ColumnNumber(ref uint value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Message(ref PWSTR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ToJson(ref PWSTR value);
}
