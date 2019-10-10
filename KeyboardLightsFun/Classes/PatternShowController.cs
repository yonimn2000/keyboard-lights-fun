using System;
using System.Timers;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class PatternShowController
    {
        /// <summary>
        /// Gets or sets the number of repeats of the show. Setting this property to a value less than 1 will make the show continuous.
        /// </summary>
        public int Repeats { get; set; }
        public int Speed { get; set; }

        public PatternShow PatternShow { get; set; }

        public Action<int, int, ToggleableKeyStates> ProgressReported;
        public Action ShowEnded;

        private readonly Timer timer;
        private int repeatCounter;

        public PatternShowController()
        {
            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            Repeats = 1;
            repeatCounter = 0;
        }

        public PatternShowController(PatternShow patternShow, int speed = 5, int repeats = 1) : this()
        {
            PatternShow = patternShow;
            Speed = speed;
            Repeats = repeats;
        }

        public bool IsShowContinuous()
        {
            return Repeats < 1;
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
            if (!PatternShow.HasNextState() && (IsShowContinuous() || repeatCounter + 1 < Repeats))
            {
                repeatCounter++;
                PatternShow.Reset();
            }
            if (PatternShow.HasNextState())
            {
                int patternShowProgressPercentage = PatternShow.GetProgressPercentage();
                ProgressReported(patternShowProgressPercentage, IsShowContinuous() ? -1 :
                    (int)Math.Round(100 * (repeatCounter + (double)patternShowProgressPercentage / 100) / Repeats),
                    PatternShow.GetCurrentToggleableKeyStates());
                PatternShow.ShowNextState();
            }
            else
                EndShow();
        }

        public void EndShow()
        {
            timer.Enabled = false;
            PatternShow.End();
            repeatCounter = 0;
            ShowEnded();
        }
    }
}