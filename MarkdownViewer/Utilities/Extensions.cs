namespace MarkdownViewer.Utilities;

public static class Extensions
{
    public static RegistryKey EnsureSubKey(this RegistryKey root, string name)
    {
        ArgumentNullException.ThrowIfNull(root);
        ArgumentNullException.ThrowIfNull(name);
        var key = root.OpenSubKey(name, true);
        if (key != null)
            return key;

        var parentName = Path.GetDirectoryName(name);
        if (string.IsNullOrEmpty(parentName))
            return root.CreateSubKey(name);

        using var parentKey = EnsureSubKey(root, parentName);
        return parentKey.CreateSubKey(Path.GetFileName(name));
    }
}
