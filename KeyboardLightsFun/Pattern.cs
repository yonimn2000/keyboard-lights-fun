using System.Collections.Generic;
using System.ComponentModel;
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

        public void StartShow(int delayBetweenStates, BackgroundWorker backgroundWorker)
        {
            backgroundWorker.ReportProgress(0);
            ToggleableKeyStates.Refresh();
            ToggleableKeyStates.Save();
            for (int i = 0; !backgroundWorker.CancellationPending && i < StatesList.Count; i++)
            {
                backgroundWorker.ReportProgress((i + 1) * 100 / StatesList.Count);
                ToggleableKeyStates.Set(StatesList[i]);
                int delayBetweenChecks = 250;
                for (int delayed = 0; !backgroundWorker.CancellationPending && delayed < delayBetweenStates; delayed += delayBetweenChecks)
                    Thread.Sleep(delayBetweenChecks);
            }
            ToggleableKeyStates.Restore();
        }

        public void EndShow()
        {
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