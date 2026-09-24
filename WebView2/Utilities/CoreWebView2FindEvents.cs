namespace WebView2.Utilities;

public sealed class CoreWebView2FindEvents(ICoreWebView2Find instance) : IDisposable
{
    private readonly ICoreWebView2Find _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _activeMatchIndexChanged;
    private EventRegistrationToken _activeMatchIndexChangedToken;
    private EventHandler? _matchCountChanged;
    private EventRegistrationToken _matchCountChangedToken;

    public CoreWebView2FindEvents(IComObject<ICoreWebView2Find> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2Find Instance => _instance;

    public event EventHandler? ActiveMatchIndexChanged
    {
        add
        {
            if (_activeMatchIndexChanged == null)
            {
                _instance.add_ActiveMatchIndexChanged(new CoreWebView2FindActiveMatchIndexChangedEventHandler((sender, args) => _activeMatchIndexChanged?.Invoke(sender, EventArgs.Empty)), ref _activeMatchIndexChangedToken).ThrowOnError();
            }

            _activeMatchIndexChanged += value;
        }
        remove
        {
            _activeMatchIndexChanged -= value;
            if (_activeMatchIndexChanged == null)
            {
                _instance.remove_ActiveMatchIndexChanged(_activeMatchIndexChangedToken);
            }
        }
    }

    public event EventHandler? MatchCountChanged
    {
        add
        {
            if (_matchCountChanged == null)
            {
                _instance.add_MatchCountChanged(new CoreWebView2FindMatchCountChangedEventHandler((sender, args) => _matchCountChanged?.Invoke(sender, EventArgs.Empty)), ref _matchCountChangedToken).ThrowOnError();
            }

            _matchCountChanged += value;
        }
        remove
        {
            _matchCountChanged -= value;
            if (_matchCountChanged == null)
            {
                _instance.remove_MatchCountChanged(_matchCountChangedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_activeMatchIndexChanged != null)
        {
            _activeMatchIndexChanged = null;
            _instance.remove_ActiveMatchIndexChanged(_activeMatchIndexChangedToken);
        }

        if (_matchCountChanged != null)
        {
            _matchCountChanged = null;
            _instance.remove_MatchCountChanged(_matchCountChangedToken);
        }
    }
}
