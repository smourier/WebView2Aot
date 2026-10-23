#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2CrashReportExtensions
{
    extension(ICoreWebView2CrashReport instance)
    {
        public string? BucketId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_BucketId(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? CrashReportId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_CrashReportId(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public uint ExceptionCode
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_ExceptionCode(ref value).ThrowOnError();
                return value;
            }
        }

        public ulong FaultOffset
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                ulong value = default;
                instance.get_FaultOffset(ref value).ThrowOnError();
                return value;
            }
        }

        public string? FaultingModuleName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FaultingModuleName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public string? FaultingModuleVersion
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FaultingModuleVersion(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }
        }

        public ulong ReportTime
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                ulong value = default;
                instance.get_ReportTime(ref value).ThrowOnError();
                return value;
            }
        }
    }

    extension(IComObject<ICoreWebView2CrashReport> instance)
    {
        public string? BucketId
        {
            get => (instance?.Object!).BucketId;
        }

        public string? CrashReportId
        {
            get => (instance?.Object!).CrashReportId;
        }

        public uint ExceptionCode
        {
            get => (instance?.Object!).ExceptionCode;
        }

        public ulong FaultOffset
        {
            get => (instance?.Object!).FaultOffset;
        }

        public string? FaultingModuleName
        {
            get => (instance?.Object!).FaultingModuleName;
        }

        public string? FaultingModuleVersion
        {
            get => (instance?.Object!).FaultingModuleVersion;
        }

        public ulong ReportTime
        {
            get => (instance?.Object!).ReportTime;
        }
    }
}
