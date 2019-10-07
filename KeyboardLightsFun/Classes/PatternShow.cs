namespace YonatanMankovich.KeyboardLightsFun
{
    public class PatternShow
    {
        public Pattern Pattern { get; set; }
        public int CurrentIndex { get; set; } = 0;

        public PatternShow(Pattern pattern)
        {
            Pattern = pattern.Clone();
        }

        public void ShowNextState()
        {
            if (HasNextState())
            {
                ToggleableKeyStates.Set(Pattern.StatesList[CurrentIndex]);
                CurrentIndex++;
            }
        }

        public bool HasNextState()
        {
            return CurrentIndex < Pattern.StatesList.Count;
        }

        public void Start()
        {
            ToggleableKeyStates.Refresh();
            ToggleableKeyStates.Save();
        }

        public void End()
        {
            ToggleableKeyStates.Restore();
            Reset();
        }

        public void Reset()
        {
            CurrentIndex = 0;
        }

        public int GetProgressPercentage()
        {
            return System.Math.Min((int)System.Math.Round(100 * ((double)CurrentIndex + 1) / Pattern.StatesList.Count), 100);
        }

        public ToggleableKeyStates GetCurrentToggleableKeyStates()
        {
            return Pattern.StatesList[CurrentIndex];
        }
    }
}