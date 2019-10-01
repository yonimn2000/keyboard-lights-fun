using System;
using System.Collections.Generic;
using System.Threading;

namespace YonatanMankovich.KeyboardLightsFun
{
    class Pattern
    {
        public string Name { get; set; }
        public IList<ToggleableKeyStates> StatesList { get; }
        public Thread ShowThread { get; }

        public Pattern(string name, IList<ToggleableKeyStates> statesList)
        {
            Name = name;
            StatesList = new List<ToggleableKeyStates>(statesList);
            ShowThread = new ThreadStart();
        }

        public void StartShow(int delayBetweenStates)
        {
            new Thread(new ThreadStart(delegate
            {
                ToggleableKeyStates.Refresh();
                ToggleableKeyStates.Save();
                ToggleableKeyStates blankKeyStates = new ToggleableKeyStates(false, false, false);
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
                callback();
            })).Start();
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