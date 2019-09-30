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
            string output = "";
            output += SurroundWithParentheses(NumLockState ? "X" : " ") + " ";
            output += SurroundWithParentheses(CapsLockState ? "X" : " ") + " ";
            output += SurroundWithParentheses(ScrollLockState ? "X" : " ");
            return output;
        }

        private string SurroundWithParentheses(string input)
        {
            return "(" + input + ")";
        }

        private static readonly ToggleableKey numLock = new ToggleableKey(Keys.NumLock);
        private static readonly ToggleableKey capsLock = new ToggleableKey(Keys.CapsLock);
        private static readonly ToggleableKey scrollLock = new ToggleableKey(Keys.Scroll);

        private static ToggleableKeyStates savedStates;

        public static void Set(ToggleableKeyStates toggleableKeyStates)
        {
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