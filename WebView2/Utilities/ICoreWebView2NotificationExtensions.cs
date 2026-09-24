namespace WebView2.Utilities;

public static partial class ICoreWebView2NotificationExtensions
{
    public static ulong[] GetVibrationPattern(this IComObject<ICoreWebView2Notification> notification) => GetVibrationPattern(notification?.Object!);
    public static ulong[] GetVibrationPattern(this ICoreWebView2Notification notification)
    {
        ArgumentNullException.ThrowIfNull(notification);

        uint count = 0;
        notification.GetVibrationPattern(ref count, out var pattern).ThrowOnError();
        try
        {
            var values = new ulong[count];
            for (var i = 0; i < count; i++)
            {
                values[i] = (ulong)Marshal.ReadInt64(pattern, i * sizeof(ulong));
            }
            return values;
        }
        finally
        {
            Marshal.FreeCoTaskMem(pattern);
        }
    }
}
