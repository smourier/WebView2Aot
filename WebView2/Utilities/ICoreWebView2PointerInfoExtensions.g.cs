#nullable enable
namespace WebView2.Utilities;

public static partial class ICoreWebView2PointerInfoExtensions
{
    extension(ICoreWebView2PointerInfo instance)
    {
        public uint PointerKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PointerKind(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PointerKind(value).ThrowOnError();
            }
        }

        public uint PointerId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PointerId(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PointerId(value).ThrowOnError();
            }
        }

        public uint FrameId
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_FrameId(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_FrameId(value).ThrowOnError();
            }
        }

        public uint PointerFlags
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PointerFlags(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PointerFlags(value).ThrowOnError();
            }
        }

        public RECT PointerDeviceRect
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                RECT value = default;
                instance.get_PointerDeviceRect(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PointerDeviceRect(value).ThrowOnError();
            }
        }

        public RECT DisplayRect
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                RECT value = default;
                instance.get_DisplayRect(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_DisplayRect(value).ThrowOnError();
            }
        }

        public POINT PixelLocation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                POINT value = default;
                instance.get_PixelLocation(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PixelLocation(value).ThrowOnError();
            }
        }

        public POINT HimetricLocation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                POINT value = default;
                instance.get_HimetricLocation(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_HimetricLocation(value).ThrowOnError();
            }
        }

        public POINT PixelLocationRaw
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                POINT value = default;
                instance.get_PixelLocationRaw(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PixelLocationRaw(value).ThrowOnError();
            }
        }

        public POINT HimetricLocationRaw
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                POINT value = default;
                instance.get_HimetricLocationRaw(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_HimetricLocationRaw(value).ThrowOnError();
            }
        }

        public uint Time
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_Time(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_Time(value).ThrowOnError();
            }
        }

        public uint HistoryCount
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_HistoryCount(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_HistoryCount(value).ThrowOnError();
            }
        }

        public int InputData
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_InputData(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_InputData(value).ThrowOnError();
            }
        }

        public uint KeyStates
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_KeyStates(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_KeyStates(value).ThrowOnError();
            }
        }

        public ulong PerformanceCount
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                ulong value = default;
                instance.get_PerformanceCount(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PerformanceCount(value).ThrowOnError();
            }
        }

        public int ButtonChangeKind
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_ButtonChangeKind(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_ButtonChangeKind(value).ThrowOnError();
            }
        }

        public uint PenFlags
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PenFlags(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PenFlags(value).ThrowOnError();
            }
        }

        public uint PenMask
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PenMask(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PenMask(value).ThrowOnError();
            }
        }

        public uint PenPressure
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PenPressure(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PenPressure(value).ThrowOnError();
            }
        }

        public uint PenRotation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_PenRotation(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PenRotation(value).ThrowOnError();
            }
        }

        public int PenTiltX
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_PenTiltX(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PenTiltX(value).ThrowOnError();
            }
        }

        public int PenTiltY
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                int value = default;
                instance.get_PenTiltY(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_PenTiltY(value).ThrowOnError();
            }
        }

        public uint TouchFlags
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_TouchFlags(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TouchFlags(value).ThrowOnError();
            }
        }

        public uint TouchMask
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_TouchMask(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TouchMask(value).ThrowOnError();
            }
        }

        public RECT TouchContact
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                RECT value = default;
                instance.get_TouchContact(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TouchContact(value).ThrowOnError();
            }
        }

        public RECT TouchContactRaw
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                RECT value = default;
                instance.get_TouchContactRaw(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TouchContactRaw(value).ThrowOnError();
            }
        }

        public uint TouchOrientation
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_TouchOrientation(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TouchOrientation(value).ThrowOnError();
            }
        }

        public uint TouchPressure
        {
            get
            {
                ArgumentNullException.ThrowIfNull(instance);

                uint value = default;
                instance.get_TouchPressure(ref value).ThrowOnError();
                return value;
            }

            set
            {
                ArgumentNullException.ThrowIfNull(instance);

                instance.put_TouchPressure(value).ThrowOnError();
            }
        }
    }

    extension(IComObject<ICoreWebView2PointerInfo> instance)
    {
        public uint PointerKind
        {
            get => (instance?.Object!).PointerKind;
            set => (instance?.Object!).PointerKind = value;
        }

        public uint PointerId
        {
            get => (instance?.Object!).PointerId;
            set => (instance?.Object!).PointerId = value;
        }

        public uint FrameId
        {
            get => (instance?.Object!).FrameId;
            set => (instance?.Object!).FrameId = value;
        }

        public uint PointerFlags
        {
            get => (instance?.Object!).PointerFlags;
            set => (instance?.Object!).PointerFlags = value;
        }

        public RECT PointerDeviceRect
        {
            get => (instance?.Object!).PointerDeviceRect;
            set => (instance?.Object!).PointerDeviceRect = value;
        }

        public RECT DisplayRect
        {
            get => (instance?.Object!).DisplayRect;
            set => (instance?.Object!).DisplayRect = value;
        }

        public POINT PixelLocation
        {
            get => (instance?.Object!).PixelLocation;
            set => (instance?.Object!).PixelLocation = value;
        }

        public POINT HimetricLocation
        {
            get => (instance?.Object!).HimetricLocation;
            set => (instance?.Object!).HimetricLocation = value;
        }

        public POINT PixelLocationRaw
        {
            get => (instance?.Object!).PixelLocationRaw;
            set => (instance?.Object!).PixelLocationRaw = value;
        }

        public POINT HimetricLocationRaw
        {
            get => (instance?.Object!).HimetricLocationRaw;
            set => (instance?.Object!).HimetricLocationRaw = value;
        }

        public uint Time
        {
            get => (instance?.Object!).Time;
            set => (instance?.Object!).Time = value;
        }

        public uint HistoryCount
        {
            get => (instance?.Object!).HistoryCount;
            set => (instance?.Object!).HistoryCount = value;
        }

        public int InputData
        {
            get => (instance?.Object!).InputData;
            set => (instance?.Object!).InputData = value;
        }

        public uint KeyStates
        {
            get => (instance?.Object!).KeyStates;
            set => (instance?.Object!).KeyStates = value;
        }

        public ulong PerformanceCount
        {
            get => (instance?.Object!).PerformanceCount;
            set => (instance?.Object!).PerformanceCount = value;
        }

        public int ButtonChangeKind
        {
            get => (instance?.Object!).ButtonChangeKind;
            set => (instance?.Object!).ButtonChangeKind = value;
        }

        public uint PenFlags
        {
            get => (instance?.Object!).PenFlags;
            set => (instance?.Object!).PenFlags = value;
        }

        public uint PenMask
        {
            get => (instance?.Object!).PenMask;
            set => (instance?.Object!).PenMask = value;
        }

        public uint PenPressure
        {
            get => (instance?.Object!).PenPressure;
            set => (instance?.Object!).PenPressure = value;
        }

        public uint PenRotation
        {
            get => (instance?.Object!).PenRotation;
            set => (instance?.Object!).PenRotation = value;
        }

        public int PenTiltX
        {
            get => (instance?.Object!).PenTiltX;
            set => (instance?.Object!).PenTiltX = value;
        }

        public int PenTiltY
        {
            get => (instance?.Object!).PenTiltY;
            set => (instance?.Object!).PenTiltY = value;
        }

        public uint TouchFlags
        {
            get => (instance?.Object!).TouchFlags;
            set => (instance?.Object!).TouchFlags = value;
        }

        public uint TouchMask
        {
            get => (instance?.Object!).TouchMask;
            set => (instance?.Object!).TouchMask = value;
        }

        public RECT TouchContact
        {
            get => (instance?.Object!).TouchContact;
            set => (instance?.Object!).TouchContact = value;
        }

        public RECT TouchContactRaw
        {
            get => (instance?.Object!).TouchContactRaw;
            set => (instance?.Object!).TouchContactRaw = value;
        }

        public uint TouchOrientation
        {
            get => (instance?.Object!).TouchOrientation;
            set => (instance?.Object!).TouchOrientation = value;
        }

        public uint TouchPressure
        {
            get => (instance?.Object!).TouchPressure;
            set => (instance?.Object!).TouchPressure = value;
        }
    }
}
