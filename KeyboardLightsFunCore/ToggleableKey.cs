using System;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class ToggleableKey
    {
        private bool _state;

        public Keys Key { get; set; }
        public bool State
        {
            get => _state;
            set
            {
                if (value != _state)
                    Toggle();
            }
        }

        public ToggleableKey(Keys key)
        {
            Key = key;
            RefreshState();
        }

        public void RefreshState()
        {
            _state = Control.IsKeyLocked(Key);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public void Toggle()
        {
            keybd_event((byte)Key, 69, 1, (UIntPtr)0); // Key press
            keybd_event((byte)Key, 69, 1 | 2, (UIntPtr)0); // Key release
            _state = !_state;
        }
    }
}