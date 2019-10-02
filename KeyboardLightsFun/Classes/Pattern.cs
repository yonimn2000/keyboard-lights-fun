using System.Collections.Generic;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class Pattern
    {
        public string Name { get; set; }
        public IList<ToggleableKeyStates> StatesList { get; }

        public Pattern(string name, IList<ToggleableKeyStates> statesList) : this(name)
        {
            StatesList = new List<ToggleableKeyStates>(statesList);
        }

        public Pattern(string name)
        {
            Name = name;
            StatesList = new List<ToggleableKeyStates>();
        }

        public void StartShow(int delayBetweenStates, System.ComponentModel.BackgroundWorker backgroundWorker)
        {
            backgroundWorker.ReportProgress(0);
            ToggleableKeyStates.Refresh();
            ToggleableKeyStates.Save();
            for (int i = 0; !backgroundWorker.CancellationPending && i < StatesList.Count; i++)
            {
                backgroundWorker.ReportProgress((i + 1) * 100 / StatesList.Count);
                ToggleableKeyStates.Set(StatesList[i]);
                System.Threading.Thread.Sleep(delayBetweenStates);
            }
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