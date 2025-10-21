namespace HelloCompositionWebView2;

public static class Extensions
{
    public static POINT ToPOINT(this LPARAM lParam) => new(lParam.Value.SignedLOWORD(), lParam.Value.SignedHIWORD());
    public static POINT ScreenToClient(this POINT pt, HWND hwnd) { DirectN.Functions.ScreenToClient(hwnd, ref pt); return pt; }
    public static POINT ClientToScreen(this POINT pt, HWND hwnd) { DirectN.Functions.ClientToScreen(hwnd, ref pt); return pt; }

    public static MouseButton MessageToButton(uint msg, WPARAM wParam)
    {
        switch (msg)
        {
            case MessageDecoder.WM_LBUTTONDOWN:
            case MessageDecoder.WM_LBUTTONUP:
            case MessageDecoder.WM_LBUTTONDBLCLK:
            case MessageDecoder.WM_NCLBUTTONDOWN:
            case MessageDecoder.WM_NCLBUTTONUP:
            case MessageDecoder.WM_NCLBUTTONDBLCLK:
                return MouseButton.Left;

            case MessageDecoder.WM_RBUTTONDOWN:
            case MessageDecoder.WM_RBUTTONUP:
            case MessageDecoder.WM_RBUTTONDBLCLK:
            case MessageDecoder.WM_NCRBUTTONDOWN:
            case MessageDecoder.WM_NCRBUTTONUP:
            case MessageDecoder.WM_NCRBUTTONDBLCLK:
                return MouseButton.Right;

            case MessageDecoder.WM_MBUTTONDOWN:
            case MessageDecoder.WM_MBUTTONUP:
            case MessageDecoder.WM_MBUTTONDBLCLK:
            case MessageDecoder.WM_NCMBUTTONDOWN:
            case MessageDecoder.WM_NCMBUTTONUP:
            case MessageDecoder.WM_NCMBUTTONDBLCLK:
                return MouseButton.Middle;

            case MessageDecoder.WM_XBUTTONDOWN:
            case MessageDecoder.WM_XBUTTONUP:
            case MessageDecoder.WM_XBUTTONDBLCLK:
            case MessageDecoder.WM_NCXBUTTONDOWN:
            case MessageDecoder.WM_NCXBUTTONUP:

                var xb = wParam.Value.HIWORD();
                if (xb == 1)
                    return MouseButton.X1;

                if (xb == 2)
                    return MouseButton.X2;

                break;
        }
        throw new NotSupportedException();
    }

    public static COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS GetKeys(this POINTER_MOD vk, MouseButton? button = null) => GetKeys((MODIFIERKEYS_FLAGS)vk, button);
    public static COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS GetKeys(this MODIFIERKEYS_FLAGS vk, MouseButton? button = null)
    {
        var keys = COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_NONE;
        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_CONTROL))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_CONTROL;
        }

        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_SHIFT))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_SHIFT;
        }

        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_LBUTTON))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_LEFT_BUTTON;
        }

        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_RBUTTON))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_RIGHT_BUTTON;
        }

        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_MBUTTON))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_MIDDLE_BUTTON;
        }

        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_XBUTTON1))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_X_BUTTON1;
        }

        if (vk.HasFlag(MODIFIERKEYS_FLAGS.MK_XBUTTON2))
        {
            keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_X_BUTTON2;
        }

        if (button != null)
        {
            switch (button.Value)
            {
                case MouseButton.Left:
                    keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_LEFT_BUTTON;
                    break;

                case MouseButton.Right:
                    keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_RIGHT_BUTTON;
                    break;

                case MouseButton.Middle:
                    keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_MIDDLE_BUTTON;
                    break;

                case MouseButton.X1:
                    keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_X_BUTTON1;
                    break;

                case MouseButton.X2:
                    keys |= COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_X_BUTTON2;
                    break;
            }
        }
        return keys;
    }

    public static COREWEBVIEW2_MOUSE_EVENT_KIND GetKind(this MouseButton button, ButtonAction action)
    {
        switch (button)
        {
            case MouseButton.Left:
                switch (action)
                {
                    case ButtonAction.Down: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_LEFT_BUTTON_DOWN;
                    case ButtonAction.Up: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_LEFT_BUTTON_UP;
                    case ButtonAction.DoubleClick: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_LEFT_BUTTON_DOUBLE_CLICK;
                }
                break;

            case MouseButton.Right:
                switch (action)
                {
                    case ButtonAction.Down: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_RIGHT_BUTTON_DOWN;
                    case ButtonAction.Up: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_RIGHT_BUTTON_UP;
                    case ButtonAction.DoubleClick: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_RIGHT_BUTTON_DOUBLE_CLICK;
                }
                break;

            case MouseButton.Middle:
                switch (action)
                {
                    case ButtonAction.Down: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_MIDDLE_BUTTON_DOWN;
                    case ButtonAction.Up: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_MIDDLE_BUTTON_UP;
                    case ButtonAction.DoubleClick: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_MIDDLE_BUTTON_DOUBLE_CLICK;
                }
                break;

            case MouseButton.X1:
            case MouseButton.X2:
                switch (action)
                {
                    case ButtonAction.Down: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_X_BUTTON_DOWN;
                    case ButtonAction.Up: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_X_BUTTON_UP;
                    case ButtonAction.DoubleClick: return COREWEBVIEW2_MOUSE_EVENT_KIND.COREWEBVIEW2_MOUSE_EVENT_KIND_X_BUTTON_DOUBLE_CLICK;
                }
                break;
        }
        throw new NotSupportedException();
    }
}
