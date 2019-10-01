using System.Collections.Generic;
using System.Threading;

namespace YonatanMankovich.KeyboardLightsFun
{
    class Pattern
    {
        public string Name { get; set; }
        public IList<ToggleableKeyStates> StatesList { get; }

        public Pattern(string name, IList<ToggleableKeyStates> statesList)
        {
            Name = name;
            StatesList = new List<ToggleableKeyStates>(statesList);
        }

        public void Show(int delayBetweenStates)
        {
            ToggleableKeyStates.Save();
            ToggleableKeyStates blankKeyStates = new ToggleableKeyStates(false,false,false);
            ToggleableKeyStates.Set(blankKeyStates);
            Thread.Sleep(delayBetweenStates);
            foreach (ToggleableKeyStates toggleableKeyStates in StatesList)
            {
                ToggleableKeyStates.Set(toggleableKeyStates);
                Thread.Sleep(delayBetweenStates);
            }
            ToggleableKeyStates.Set(blankKeyStates);
            Thread.Sleep(delayBetweenStates);
            ToggleableKeyStates.Restore();
        }

        public Pattern Clone()
        {
            return new Pattern(Name, StatesList);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}