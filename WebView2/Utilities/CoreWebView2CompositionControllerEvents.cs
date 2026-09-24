namespace WebView2.Utilities;

public sealed class CoreWebView2CompositionControllerEvents(ICoreWebView2CompositionController instance) : IDisposable
{
    private readonly ICoreWebView2CompositionController _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _cursorChanged;
    private EventRegistrationToken _cursorChangedToken;
    private EventHandler<ICoreWebView2NonClientRegionChangedEventArgs>? _nonClientRegionChanged;
    private EventRegistrationToken _nonClientRegionChangedToken;
    private EventHandler<ICoreWebView2DragStartingEventArgs>? _dragStarting;
    private EventRegistrationToken _dragStartingToken;

    public CoreWebView2CompositionControllerEvents(IComObject<ICoreWebView2CompositionController> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2CompositionController Instance => _instance;

    public event EventHandler? CursorChanged
    {
        add
        {
            if (_cursorChanged == null)
            {
                _instance.add_CursorChanged(new CoreWebView2CursorChangedEventHandler((sender, args) => _cursorChanged?.Invoke(sender, EventArgs.Empty)), ref _cursorChangedToken).ThrowOnError();
            }

            _cursorChanged += value;
        }
        remove
        {
            _cursorChanged -= value;
            if (_cursorChanged == null)
            {
                _instance.remove_CursorChanged(_cursorChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController4"/>.</remarks>
    public event EventHandler<ICoreWebView2NonClientRegionChangedEventArgs>? NonClientRegionChanged
    {
        add
        {
            if (_nonClientRegionChanged == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController4>(_instance) is not { } typed)
                    return;

                typed.add_NonClientRegionChanged(new CoreWebView2NonClientRegionChangedEventHandler((sender, args) => _nonClientRegionChanged?.Invoke(sender, args)), ref _nonClientRegionChangedToken).ThrowOnError();
            }

            _nonClientRegionChanged += value;
        }
        remove
        {
            _nonClientRegionChanged -= value;
            if (_nonClientRegionChanged == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2CompositionController4>(_instance)?.remove_NonClientRegionChanged(_nonClientRegionChangedToken);
            }
        }
    }

    /// <remarks>Requires <see cref="ICoreWebView2CompositionController5"/>.</remarks>
    public event EventHandler<ICoreWebView2DragStartingEventArgs>? DragStarting
    {
        add
        {
            if (_dragStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2CompositionController5>(_instance) is not { } typed)
                    return;

                typed.add_DragStarting(new CoreWebView2DragStartingEventHandler((sender, args) => _dragStarting?.Invoke(sender, args)), ref _dragStartingToken).ThrowOnError();
            }

            _dragStarting += value;
        }
        remove
        {
            _dragStarting -= value;
            if (_dragStarting == null)
            {
                WebView2Utilities.GetInterface<ICoreWebView2CompositionController5>(_instance)?.remove_DragStarting(_dragStartingToken);
            }
        }
    }

    public void Dispose()
    {
        if (_cursorChanged != null)
        {
            _cursorChanged = null;
            _instance.remove_CursorChanged(_cursorChangedToken);
        }

        if (_nonClientRegionChanged != null)
        {
            _nonClientRegionChanged = null;
            WebView2Utilities.GetInterface<ICoreWebView2CompositionController4>(_instance)?.remove_NonClientRegionChanged(_nonClientRegionChangedToken);
        }

        if (_dragStarting != null)
        {
            _dragStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2CompositionController5>(_instance)?.remove_DragStarting(_dragStartingToken);
        }
    }
}
