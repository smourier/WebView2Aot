namespace WebView2.Utilities;

public sealed class CoreWebView2DownloadOperationEvents(ICoreWebView2DownloadOperation instance) : IDisposable
{
    private readonly ICoreWebView2DownloadOperation _instance = instance ?? throw new ArgumentNullException(nameof(instance));
    private EventHandler? _bytesReceivedChanged;
    private EventRegistrationToken _bytesReceivedChangedToken;
    private EventHandler? _estimatedEndTimeChanged;
    private EventRegistrationToken _estimatedEndTimeChangedToken;
    private EventHandler? _stateChanged;
    private EventRegistrationToken _stateChangedToken;

    public CoreWebView2DownloadOperationEvents(IComObject<ICoreWebView2DownloadOperation> instance)
        : this(instance?.Object!)
    {
    }

    public ICoreWebView2DownloadOperation Instance => _instance;

    public event EventHandler? BytesReceivedChanged
    {
        add
        {
            if (_bytesReceivedChanged == null)
            {
                _instance.add_BytesReceivedChanged(new CoreWebView2BytesReceivedChangedEventHandler((sender, args) => _bytesReceivedChanged?.Invoke(sender, EventArgs.Empty)), ref _bytesReceivedChangedToken).ThrowOnError();
            }

            _bytesReceivedChanged += value;
        }
        remove
        {
            _bytesReceivedChanged -= value;
            if (_bytesReceivedChanged == null)
            {
                _instance.remove_BytesReceivedChanged(_bytesReceivedChangedToken);
            }
        }
    }

    public event EventHandler? EstimatedEndTimeChanged
    {
        add
        {
            if (_estimatedEndTimeChanged == null)
            {
                _instance.add_EstimatedEndTimeChanged(new CoreWebView2EstimatedEndTimeChangedEventHandler((sender, args) => _estimatedEndTimeChanged?.Invoke(sender, EventArgs.Empty)), ref _estimatedEndTimeChangedToken).ThrowOnError();
            }

            _estimatedEndTimeChanged += value;
        }
        remove
        {
            _estimatedEndTimeChanged -= value;
            if (_estimatedEndTimeChanged == null)
            {
                _instance.remove_EstimatedEndTimeChanged(_estimatedEndTimeChangedToken);
            }
        }
    }

    public event EventHandler? StateChanged
    {
        add
        {
            if (_stateChanged == null)
            {
                _instance.add_StateChanged(new CoreWebView2StateChangedEventHandler((sender, args) => _stateChanged?.Invoke(sender, EventArgs.Empty)), ref _stateChangedToken).ThrowOnError();
            }

            _stateChanged += value;
        }
        remove
        {
            _stateChanged -= value;
            if (_stateChanged == null)
            {
                _instance.remove_StateChanged(_stateChangedToken);
            }
        }
    }

    public void Dispose()
    {
        if (_bytesReceivedChanged != null)
        {
            _bytesReceivedChanged = null;
            _instance.remove_BytesReceivedChanged(_bytesReceivedChangedToken);
        }

        if (_estimatedEndTimeChanged != null)
        {
            _estimatedEndTimeChanged = null;
            _instance.remove_EstimatedEndTimeChanged(_estimatedEndTimeChangedToken);
        }

        if (_stateChanged != null)
        {
            _stateChanged = null;
            _instance.remove_StateChanged(_stateChangedToken);
        }
    }
}
