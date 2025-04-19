#nullable enable
namespace WebView2;

[GeneratedComInterface, Guid("b747a495-0c6f-449e-97b8-2f81e9d6ab43")]
public partial interface ICoreWebView2SharedBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Size(ref ulong value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Buffer(out nint /* byte array */ value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenStream(out IStream value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FileMappingHandle(ref HANDLE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
