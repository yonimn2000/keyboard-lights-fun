using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public struct ToggleableKeyStates
    {
        public bool NumLockState { get; set; }
        public bool CapsLockState { get; set; }
        public bool ScrollLockState { get; set; }

        public ToggleableKeyStates(bool numLockState, bool capsLockState, bool scrollLockState)
        {
            NumLockState = numLockState;
            CapsLockState = capsLockState;
            ScrollLockState = scrollLockState;
        }

        public override string ToString()
        {
            string output = "(";
            output += (NumLockState ? "X" : " ") + ") (";
            output += (CapsLockState ? "X" : " ") + ") (";
            output += (ScrollLockState ? "X" : " ");
            return output + ")";
        }

        private static readonly ToggleableKey numLock = new ToggleableKey(Keys.NumLock);
        private static readonly ToggleableKey capsLock = new ToggleableKey(Keys.CapsLock);
        private static readonly ToggleableKey scrollLock = new ToggleableKey(Keys.Scroll);

        private static ToggleableKeyStates savedStates;

        public static void Set(ToggleableKeyStates toggleableKeyStates)
        {
            numLock.State = toggleableKeyStates.NumLockState;
            capsLock.State = toggleableKeyStates.CapsLockState;
            scrollLock.State = toggleableKeyStates.ScrollLockState;
        }

        public static void Refresh()
        {
            numLock.RefreshState();
            capsLock.RefreshState();
            scrollLock.RefreshState();
        }

        public static void Save()
        {
            savedStates = new ToggleableKeyStates(numLock.State, capsLock.State, scrollLock.State);
        }

        public static void Restore()
        {
            numLock.State = savedStates.NumLockState;
            capsLock.State = savedStates.CapsLockState;
            scrollLock.State = savedStates.ScrollLockState;
        }
    }
}