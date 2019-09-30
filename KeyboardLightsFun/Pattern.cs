using System.Collections.Generic;
using System.Threading;

namespace YonatanMankovich.KeyboardLightsFun
{
    class Pattern
    {
        public string Name { get; set; }

        public IList<ToggleableKeyStates> StatesList { get; }

        public Pattern(string name)
        {
            Name = name;
            StatesList = new List<ToggleableKeyStates>();
        }

        public void Show(int delayBetweenStates)
        {
            ToggleableKeyStates.Save();
            foreach (ToggleableKeyStates toggleableKeyStates in StatesList)
            {
                ToggleableKeyStates.Set(toggleableKeyStates);
                Thread.Sleep(delayBetweenStates);
            }
            ToggleableKeyStates.Restore();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}