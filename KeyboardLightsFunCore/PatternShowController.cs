using System;
using System.Timers;

namespace YonatanMankovich.KeyboardLightsFun
{
    public class PatternShowController
    {
        /// <summary>
        /// Gets or sets the number of repeats of the show.
        /// Setting this property to a value less than 1 will make the show continuous.
        /// </summary>
        public int Repeats { get; set; }

        /// <summary>
        /// Gets or sets the speed of the show - which determines the delay between states
        /// using the following formula: Delay in milliseconds = 1000 / Speed.
        /// </summary>
        public double Speed { get; set; }

        public PatternShow PatternShow { get; set; }

        /// <summary> Represents the callback function to call when a show progress is reported. </summary>
        public Action<int, int, ToggleableKeyStates> ProgressReported;

        /// <summary> Represents the callback function to call when the show ends. </summary>
        public Action ShowEnded;

        private readonly Timer timer;
        private int repeatCounter;

        public PatternShowController()
        {
            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            Repeats = 1;
            repeatCounter = 0;
            Speed = 5;
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
            if (IsShowing())
            {
                timer.Enabled = false;
                PatternShow.End();
                repeatCounter = 0;
                ShowEnded();
            }
        }
    }
}