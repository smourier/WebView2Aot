#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2DragStartingEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2DragStartingEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? value;
        instance.GetDeferral(out ICoreWebView2Deferral valueNative).ThrowOnError();
        value = valueNative != null ? new ComObject<ICoreWebView2Deferral>(valueNative) : null;
        return value;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2DragStartingEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2DragStartingEventArgs instance)
    {
        public uint AllowedDropEffects
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_AllowedDropEffects(ref value).ThrowOnError();
                return value;
            }
        }

        public IDataObject Data
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Data(out IDataObject value).ThrowOnError();
                return value;
            }
        }

        public bool Handled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_Handled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Handled(value).ThrowOnError();
            }
        }

        public POINT Position
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                POINT value = default;
                instance.get_Position(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2DragStartingEventArgs> instance)
    {
        public uint AllowedDropEffects
        {
            get => (instance?.Object!).AllowedDropEffects;
        }

        public IDataObject Data
        {
            get => (instance?.Object!).Data;
        }

        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }

        public POINT Position
        {
            get => (instance?.Object!).Position;
        }
    }
}
