namespace WebView2.Utilities;

public class UnsupportedInterfaceEventArgs(Type interfaceType, string? memberName, bool @throw) : EventArgs
{
    public Type InterfaceType { get; } = interfaceType;
    public string? MemberName { get; } = memberName;
    public bool Throw { get; set; } = @throw;
}
