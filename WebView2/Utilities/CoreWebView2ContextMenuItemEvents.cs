namespace WebView2.Utilities;

public sealed class CoreWebView2ContextMenuItemEvents(ICoreWebView2ContextMenuItem instance) : IDisposable
{
    private readonly ICoreWebView2ContextMenuItem _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _customItemSelected;
    private EventRegistrationToken _customItemSelectedToken;

    public CoreWebView2ContextMenuItemEvents(IComObject<ICoreWebView2ContextMenuItem> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2ContextMenuItem Instance => _instance;

    public event EventHandler? CustomItemSelected
    {
        add
        {
            if (_customItemSelected == null)
            {
                _instance.add_CustomItemSelected(new CoreWebView2CustomItemSelectedEventHandler((sender, args) => _customItemSelected?.Invoke(sender, EventArgs.Empty)), ref _customItemSelectedToken).ThrowOnError();
            }

            _customItemSelected += value;
        }
        remove
        {
            _customItemSelected -= value;
            if (_customItemSelected == null)
            {
                _instance.remove_CustomItemSelected(_customItemSelectedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_customItemSelected != null)
        {
            _customItemSelected = null;
            _instance.remove_CustomItemSelected(_customItemSelectedToken);
        }
    }
}
