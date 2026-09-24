#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2PermissionSettingExtensions
{
    extension(ICoreWebView2PermissionSetting instance)
    {
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

        public string? PermissionOrigin
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_PermissionOrigin(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public COREWEBVIEW2_PERMISSION_STATE PermissionState
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PERMISSION_STATE value = default;
                instance.get_PermissionState(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2PermissionSetting> instance)
    {
        public COREWEBVIEW2_PERMISSION_KIND PermissionKind
        {
            get => (instance?.Object!).PermissionKind;
        }

        public string? PermissionOrigin
        {
            get => (instance?.Object!).PermissionOrigin;
        }

        public COREWEBVIEW2_PERMISSION_STATE PermissionState
        {
            get => (instance?.Object!).PermissionState;
        }
    }
}
