using System;
using System.Timers;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class PatternShowController
    {
        public int Speed { get; set; }
        public bool IsShowContinuous { get; set; }
        public PatternShow PatternShow { get; set; }

        public event EventHandler<ShowProgressChangedEventArgs> ProgressReported;
        public event EventHandler ShowEnded;

        private readonly Timer timer = new Timer();

        public PatternShowController(PatternShow patternShow, int speed = 5, bool isShowContinuous = false)
        {
            PatternShow = patternShow;
            Speed = speed;
            IsShowContinuous = isShowContinuous;
        }

        public void StartShow()
        {
            timer.Interval = 1000 / Speed;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            PatternShow.Start();
        }

        public bool IsShowing()
        {
            return timer.Enabled;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (PatternShow.HasNextState())
            {
                ProgressReported(this, new ShowProgressChangedEventArgs(PatternShow.GetProgressPercentage(), PatternShow.GetCurrentToggleableKeyStates()));
                PatternShow.ShowNextState();
            }
            else
                EndShow();
        }

        public void EndShow()
        {
            if (IsShowContinuous)
                PatternShow.Reset();
            else
            {
                timer.Enabled = false;
                PatternShow.End();
                ShowEnded(this, EventArgs.Empty);
            }
        }
    }

    public class ShowProgressChangedEventArgs : EventArgs
    {
        public int ProgressPercentage { get; }
        public ToggleableKeyStates CurrentToggleableKeyStates { get; set; }

        public ShowProgressChangedEventArgs(int progressPercentage, ToggleableKeyStates currentToggleableKeyStates)
        {
            ProgressPercentage = progressPercentage;
            CurrentToggleableKeyStates = currentToggleableKeyStates;
        }
    }
}