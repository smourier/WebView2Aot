﻿#nullable enable
namespace WebView2;

[Flags]
public enum COREWEBVIEW2_RELEASE_CHANNELS
{
    COREWEBVIEW2_RELEASE_CHANNELS_NONE = 0,
    COREWEBVIEW2_RELEASE_CHANNELS_STABLE = 1,
    COREWEBVIEW2_RELEASE_CHANNELS_BETA = 2,
    COREWEBVIEW2_RELEASE_CHANNELS_DEV = 4,
    COREWEBVIEW2_RELEASE_CHANNELS_CANARY = 8,
}
