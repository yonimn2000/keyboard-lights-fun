using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class ToggleableKeyStates
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
            System.Diagnostics.Debug.WriteLine(toggleableKeyStates); //TODO: Remove
            numLock.SetState(toggleableKeyStates.NumLockState);
            capsLock.SetState(toggleableKeyStates.CapsLockState);
            scrollLock.SetState(toggleableKeyStates.ScrollLockState);
        }

        public static void Save()
        {
            savedStates = new ToggleableKeyStates(numLock.GetState(), capsLock.GetState(), scrollLock.GetState());
        }

        public static void Restore()
        {
            numLock.SetState(savedStates.NumLockState);
            capsLock.SetState(savedStates.CapsLockState);
            scrollLock.SetState(savedStates.ScrollLockState);
        }
    }
}