using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class ToggleableKey
    {
        public Keys Key { get; set; }

        public ToggleableKey(Keys key)
        {
            Key = key;
        }

        [DllImport("user32.dll")]
        static extern short GetKeyState(byte keyCode);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public bool GetState()
        {
            return GetKeyState((byte)Key) == 1;
        }

        public void SetState(bool state = true)
        {
            if (state != GetState())
                Toggle();
        }

        public void Toggle()
        {
            keybd_event((byte)Key, 69, 1, (UIntPtr)0); // Key press
            keybd_event((byte)Key, 69, 1 | 2, (UIntPtr)0); // Key release
        }
    }
}