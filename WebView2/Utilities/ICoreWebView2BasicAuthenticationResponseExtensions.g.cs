#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2BasicAuthenticationResponseExtensions
{
    extension(ICoreWebView2BasicAuthenticationResponse instance)
    {
        public string? UserName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_UserName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_UserName(valueStr).ThrowOnError();
            }
        }

        public string? Password
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_Password(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_Password(valueStr).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2BasicAuthenticationResponse> instance)
    {
        public string? UserName
        {
            get => (instance?.Object!).UserName;
            set => (instance?.Object!).UserName = value;
        }

        public string? Password
        {
            get => (instance?.Object!).Password;
            set => (instance?.Object!).Password = value;
        }
    }
}
