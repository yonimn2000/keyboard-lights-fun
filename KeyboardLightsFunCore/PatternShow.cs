namespace YonatanMankovich.KeyboardLightsFun
{
    public class PatternShow
    {
        public Pattern Pattern { get; set; }

        /// <summary> Gets or sets the index position of the current state of the pattern in the show. </summary>
        public int CurrentIndex { get; set; } = 0;

        public PatternShow() { }

        public PatternShow(Pattern pattern)
        {
            Pattern = pattern;
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
            ToggleableKeyStates.Refresh(); // Calling this method is needed for each new show to work correctly.
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

        /// <summary> Returns a percentage from 0 to 100 of the show progress. </summary>
        public int GetProgressPercentage()
        {
            return System.Math.Min((int)System.Math.Round(100 * ((double)CurrentIndex + 1) / Pattern.StatesList.Count), 100);
        }

        /// <summary> Returns the current state of the toggle-able keys. </summary>
        public ToggleableKeyStates GetCurrentToggleableKeyStates()
        {
            return Pattern.StatesList[CurrentIndex];
        }
    }
}