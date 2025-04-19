#nullable enable
namespace WebView2;

public partial struct COREWEBVIEW2_PHYSICAL_KEY_STATUS
{
    public uint RepeatCount;
    public uint ScanCode;
    public BOOL IsExtendedKey;
    public BOOL IsMenuKeyDown;
    public BOOL WasKeyDown;
    public BOOL IsKeyReleased;
}
