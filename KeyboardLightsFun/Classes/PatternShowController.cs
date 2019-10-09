using System;
using System.Timers;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class PatternShowController
    {
        public int Speed { get; set; }
        public bool IsShowContinuous { get; set; } = false;
        public PatternShow PatternShow { get; set; }

        public Action<int, ToggleableKeyStates> ProgressReported;
        public Action ShowEnded;

        private readonly Timer timer = new Timer();

        public PatternShowController()
        {
            timer.Elapsed += Timer_Elapsed;
        }

        public PatternShowController(PatternShow patternShow, int speed = 5, bool isShowContinuous = false) : this()
        {
            PatternShow = patternShow;
            Speed = speed;
            IsShowContinuous = isShowContinuous;
        }

        public void StartShow()
        {
            timer.Interval = 1000 / Speed;
            timer.Enabled = true;
            PatternShow.Start();
        }

        public bool IsShowing()
        {
            return timer.Enabled;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Interval = 1000 / Speed; // Speed might change during the show.
            if (!PatternShow.HasNextState() && IsShowContinuous)
                PatternShow.Reset();
            if (PatternShow.HasNextState())
            {
                ProgressReported(PatternShow.GetProgressPercentage(), PatternShow.GetCurrentToggleableKeyStates());
                PatternShow.ShowNextState();
            }
            else
                EndShow();
        }

        public void EndShow()
        {
            timer.Enabled = false;
            PatternShow.End();
            ShowEnded();
        }
    }
}