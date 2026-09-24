#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2PrintSettingsExtensions
{
    extension(ICoreWebView2PrintSettings instance)
    {
        public COREWEBVIEW2_PRINT_ORIENTATION Orientation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                COREWEBVIEW2_PRINT_ORIENTATION value = default;
                instance.get_Orientation(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Orientation(value).ThrowOnError();
            }
        }

        public double ScaleFactor
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_ScaleFactor(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ScaleFactor(value).ThrowOnError();
            }
        }

        public double PageWidth
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_PageWidth(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PageWidth(value).ThrowOnError();
            }
        }

        public double PageHeight
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_PageHeight(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PageHeight(value).ThrowOnError();
            }
        }

        public double MarginTop
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_MarginTop(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_MarginTop(value).ThrowOnError();
            }
        }

        public double MarginBottom
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_MarginBottom(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_MarginBottom(value).ThrowOnError();
            }
        }

        public double MarginLeft
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_MarginLeft(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_MarginLeft(value).ThrowOnError();
            }
        }

        public double MarginRight
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                double value = default;
                instance.get_MarginRight(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_MarginRight(value).ThrowOnError();
            }
        }

        public bool ShouldPrintBackgrounds
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldPrintBackgrounds(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ShouldPrintBackgrounds(value).ThrowOnError();
            }
        }

        public bool ShouldPrintSelectionOnly
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldPrintSelectionOnly(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ShouldPrintSelectionOnly(value).ThrowOnError();
            }
        }

        public bool ShouldPrintHeaderAndFooter
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                var value = BOOL.FALSE;
                instance.get_ShouldPrintHeaderAndFooter(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ShouldPrintHeaderAndFooter(value).ThrowOnError();
            }
        }

        public string? HeaderTitle
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_HeaderTitle(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_HeaderTitle(valueStr).ThrowOnError();
            }
        }

        public string? FooterUri
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.get_FooterUri(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                instance.put_FooterUri(valueStr).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public string? PageRanges
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                typed.get_PageRanges(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                typed.put_PageRanges(valueStr).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public int PagesPerSide
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                int value = default;
                typed.get_PagesPerSide(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                typed.put_PagesPerSide(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public int Copies
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                int value = default;
                typed.get_Copies(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                typed.put_Copies(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_COLLATION Collation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_PRINT_COLLATION value = default;
                typed.get_Collation(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                typed.put_Collation(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_COLOR_MODE ColorMode
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_PRINT_COLOR_MODE value = default;
                typed.get_ColorMode(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                typed.put_ColorMode(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_DUPLEX Duplex
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_PRINT_DUPLEX value = default;
                typed.get_Duplex(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                typed.put_Duplex(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_MEDIA_SIZE MediaSize
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                COREWEBVIEW2_PRINT_MEDIA_SIZE value = default;
                typed.get_MediaSize(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                typed.put_MediaSize(value).ThrowOnError();
            }
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public string? PrinterName
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return default;

                typed.get_PrinterName(out PWSTR value).ThrowOnError();
                return value.ToStringAndDispose();
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                if (WebView2Utilities.GetInterface<ICoreWebView2PrintSettings2>(instance) is not { } typed)
                    return;

                using var valueStr = new DirectN.Extensions.Utilities.Pwstr(value);
                typed.put_PrinterName(valueStr).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2PrintSettings> instance)
    {
        public COREWEBVIEW2_PRINT_ORIENTATION Orientation
        {
            get => (instance?.Object!).Orientation;
            set => (instance?.Object!).Orientation = value;
        }

        public double ScaleFactor
        {
            get => (instance?.Object!).ScaleFactor;
            set => (instance?.Object!).ScaleFactor = value;
        }

        public double PageWidth
        {
            get => (instance?.Object!).PageWidth;
            set => (instance?.Object!).PageWidth = value;
        }

        public double PageHeight
        {
            get => (instance?.Object!).PageHeight;
            set => (instance?.Object!).PageHeight = value;
        }

        public double MarginTop
        {
            get => (instance?.Object!).MarginTop;
            set => (instance?.Object!).MarginTop = value;
        }

        public double MarginBottom
        {
            get => (instance?.Object!).MarginBottom;
            set => (instance?.Object!).MarginBottom = value;
        }

        public double MarginLeft
        {
            get => (instance?.Object!).MarginLeft;
            set => (instance?.Object!).MarginLeft = value;
        }

        public double MarginRight
        {
            get => (instance?.Object!).MarginRight;
            set => (instance?.Object!).MarginRight = value;
        }

        public bool ShouldPrintBackgrounds
        {
            get => (instance?.Object!).ShouldPrintBackgrounds;
            set => (instance?.Object!).ShouldPrintBackgrounds = value;
        }

        public bool ShouldPrintSelectionOnly
        {
            get => (instance?.Object!).ShouldPrintSelectionOnly;
            set => (instance?.Object!).ShouldPrintSelectionOnly = value;
        }

        public bool ShouldPrintHeaderAndFooter
        {
            get => (instance?.Object!).ShouldPrintHeaderAndFooter;
            set => (instance?.Object!).ShouldPrintHeaderAndFooter = value;
        }

        public string? HeaderTitle
        {
            get => (instance?.Object!).HeaderTitle;
            set => (instance?.Object!).HeaderTitle = value;
        }

        public string? FooterUri
        {
            get => (instance?.Object!).FooterUri;
            set => (instance?.Object!).FooterUri = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public string? PageRanges
        {
            get => (instance?.Object!).PageRanges;
            set => (instance?.Object!).PageRanges = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public int PagesPerSide
        {
            get => (instance?.Object!).PagesPerSide;
            set => (instance?.Object!).PagesPerSide = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public int Copies
        {
            get => (instance?.Object!).Copies;
            set => (instance?.Object!).Copies = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_COLLATION Collation
        {
            get => (instance?.Object!).Collation;
            set => (instance?.Object!).Collation = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_COLOR_MODE ColorMode
        {
            get => (instance?.Object!).ColorMode;
            set => (instance?.Object!).ColorMode = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_DUPLEX Duplex
        {
            get => (instance?.Object!).Duplex;
            set => (instance?.Object!).Duplex = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public COREWEBVIEW2_PRINT_MEDIA_SIZE MediaSize
        {
            get => (instance?.Object!).MediaSize;
            set => (instance?.Object!).MediaSize = value;
        }

        /// <remarks>Requires <see cref="ICoreWebView2PrintSettings2"/>.</remarks>
        public string? PrinterName
        {
            get => (instance?.Object!).PrinterName;
            set => (instance?.Object!).PrinterName = value;
        }
    }
}
