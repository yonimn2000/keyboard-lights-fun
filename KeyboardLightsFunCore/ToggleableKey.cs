using System;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class ToggleableKey
    {
        private bool _state;

        public Keys Key { get; set; }

        /// <summary> Gets or sets the key state where 'true' means 'locked' and 'false' means 'unlocked'. </summary>
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

        /// <summary> Refreshes the state of the key by getting it from the system. </summary>
        public void RefreshState()
        {
            _state = Control.IsKeyLocked(Key);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public void Toggle()
        {
            keybd_event((byte)Key, 69, 1, (UIntPtr)0); // Key down
            keybd_event((byte)Key, 69, 1 | 2, (UIntPtr)0); // Key up
            _state = !_state;
        }
    }
}