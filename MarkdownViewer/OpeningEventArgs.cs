namespace MarkdownViewer;

public class OpeningEventArgs(string? filePath) : EventArgs
{
    public string? FilePath { get; } = filePath;
    public virtual string? Html { get; set; }
}
