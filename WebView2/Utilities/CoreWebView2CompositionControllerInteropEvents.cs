namespace WebView2.Utilities;

public sealed class CoreWebView2CompositionControllerInteropEvents(ICoreWebView2CompositionControllerInterop instance) : IDisposable
{
    private readonly ICoreWebView2CompositionControllerInterop _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler<ICoreWebView2DragStartingEventArgs>? _dragStarting;
    private EventRegistrationToken _dragStartingToken;

    public CoreWebView2CompositionControllerInteropEvents(IComObject<ICoreWebView2CompositionControllerInterop> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2CompositionControllerInterop Instance => _instance;

    /// <remarks>Requires <see cref="ICoreWebView2CompositionControllerInterop3"/>.</remarks>
    public event EventHandler<ICoreWebView2DragStartingEventArgs>? DragStarting
    {
        add
        {
            if (_dragStarting == null)
            {
                if (WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop3>(_instance) is not { } typed)
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
                WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop3>(_instance)?.remove_DragStarting(_dragStartingToken);
            }
        }
    }

    public void Dispose()
    {
        if (_dragStarting != null)
        {
            _dragStarting = null;
            WebView2Utilities.GetInterface<ICoreWebView2CompositionControllerInterop3>(_instance)?.remove_DragStarting(_dragStartingToken);
        }
    }
}
