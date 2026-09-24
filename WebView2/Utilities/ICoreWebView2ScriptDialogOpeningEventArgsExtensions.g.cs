#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2ScriptDialogOpeningEventArgsExtensions
{
    public static void Accept(this ICoreWebView2ScriptDialogOpeningEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        instance.Accept().ThrowOnError();
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2ScriptDialogOpeningEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static void Accept(this IComObject<ICoreWebView2ScriptDialogOpeningEventArgs> instance) => Accept(instance?.Object!);

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2ScriptDialogOpeningEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2ScriptDialogOpeningEventArgs instance)
    {
        public string? Uri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Uri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public COREWEBVIEW2_SCRIPT_DIALOG_KIND Kind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_SCRIPT_DIALOG_KIND value = default;
                instance.get_Kind(ref value).ThrowOnError();
                return value;
            }
        }

        public string? Message
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Message(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? DefaultText
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_DefaultText(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? ResultText
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_ResultText(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_ResultText(valueStr).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2ScriptDialogOpeningEventArgs> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public COREWEBVIEW2_SCRIPT_DIALOG_KIND Kind
        {
            get => (instance?.Object!).Kind;
        }

        public string? Message
        {
            get => (instance?.Object!).Message;
        }

        public string? DefaultText
        {
            get => (instance?.Object!).DefaultText;
        }

        public string? ResultText
        {
            get => (instance?.Object!).ResultText;
            set => (instance?.Object!).ResultText = value;
        }
    }
}
