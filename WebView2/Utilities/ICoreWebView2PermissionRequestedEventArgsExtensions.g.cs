#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2PermissionRequestedEventArgsExtensions
{
    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this ICoreWebView2PermissionRequestedEventArgs instance)
    {
        ArgumentNullException.ThrowIfNull(instance);

        IComObject<ICoreWebView2Deferral>? deferral;
        instance.GetDeferral(out ICoreWebView2Deferral deferralNative).ThrowOnError();
        deferral = deferralNative != null ? new ComObject<ICoreWebView2Deferral>(deferralNative) : null;
        return deferral;
    }

    public static IComObject<ICoreWebView2Deferral>? GetDeferral(this IComObject<ICoreWebView2PermissionRequestedEventArgs> instance) => GetDeferral(instance?.Object!);

    extension(ICoreWebView2PermissionRequestedEventArgs instance)
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

        public COREWEBVIEW2_PERMISSION_KIND PermissionKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PERMISSION_KIND value = default;
                instance.get_PermissionKind(ref value).ThrowOnError();
                return value;
            }
        }

        public bool IsUserInitiated
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_IsUserInitiated(ref value).ThrowOnError();
                return value;
            }
        }

        public COREWEBVIEW2_PERMISSION_STATE State
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PERMISSION_STATE value = default;
                instance.get_State(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_State(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PermissionRequestedEventArgs2"/>.</remarks>
        public bool Handled
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PermissionRequestedEventArgs2>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_Handled(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PermissionRequestedEventArgs2>(instance) is not { } typed)
                    return;

                typed.put_Handled(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PermissionRequestedEventArgs3"/>.</remarks>
        public bool SavesInProfile
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PermissionRequestedEventArgs3>(instance) is not { } typed)
                    return default;

                var value = BOOL.FALSE;
                typed.get_SavesInProfile(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PermissionRequestedEventArgs3>(instance) is not { } typed)
                    return;

                typed.put_SavesInProfile(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2PermissionRequestedEventArgs> instance)
    {
        public string? Uri
        {
            get => (instance?.Object!).Uri;
        }

        public COREWEBVIEW2_PERMISSION_KIND PermissionKind
        {
            get => (instance?.Object!).PermissionKind;
        }

        public bool IsUserInitiated
        {
            get => (instance?.Object!).IsUserInitiated;
        }

        public COREWEBVIEW2_PERMISSION_STATE State
        {
            get => (instance?.Object!).State;
            set => (instance?.Object!).State = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PermissionRequestedEventArgs2"/>.</remarks>
        public bool Handled
        {
            get => (instance?.Object!).Handled;
            set => (instance?.Object!).Handled = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PermissionRequestedEventArgs3"/>.</remarks>
        public bool SavesInProfile
        {
            get => (instance?.Object!).SavesInProfile;
            set => (instance?.Object!).SavesInProfile = value;
        }
    }
}
