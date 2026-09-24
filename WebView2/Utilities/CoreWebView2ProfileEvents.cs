namespace WebView2.Utilities;

public sealed class CoreWebView2ProfileEvents(ICoreWebView2Profile instance) : IDisposable
{
    private readonly ICoreWebView2Profile _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _deleted;
    private EventRegistrationToken _deletedToken;

    public CoreWebView2ProfileEvents(IComObject<ICoreWebView2Profile> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2Profile Instance => _instance;

    /// <remarks>Requires <see cref="ICoreWebView2Profile8"/>.</remarks>
    public event EventHandler? Deleted
    {
        add
        {
            if (_deleted == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2Profile8>(_instance) is not { } typed)
                    return;

                typed.add_Deleted(new CoreWebView2ProfileDeletedEventHandler((sender, args) => _deleted?.Invoke(sender, EventArgs.Empty)), ref _deletedToken).ThrowOnError();
            }

            _deleted += value;
        }
        remove
        {
            _deleted -= value;
            if (_deleted == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2Profile8>(_instance)?.remove_Deleted(_deletedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_deleted != null)
        {
            _deleted = null;
            WebView2Utilities.GetInterface<ICoreWebView2Profile8>(_instance)?.remove_Deleted(_deletedToken);
        }
    }
}
