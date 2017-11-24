using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;

namespace KeyboardLights
{
    public partial class MainForm : Form
    {
        public struct Pattern
        {
            public List<int> pattern;
            public int reverseNum;//-1 if no reverse. -2 if is reverse
            public string name;
            public Pattern(List<int> _pattern, int _reverseNum, string _name)
            {
                pattern = _pattern;
                reverseNum = _reverseNum;
                name = _name;
            }
        }

        List<Pattern> patterns = new List<Pattern>();
        List<Pattern> reversePatterns = new List<Pattern>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            patterns.Add(new Pattern(new List<int>() { 100, 010, 001, 010 }, -1, "TBD"));
            patterns.Add(new Pattern(new List<int>() { 101, 010 }, -1, "Inside Out"));
            patterns.Add(new Pattern(new List<int>() { 110, 011 }, -1, "Dance"));
            patterns.Add(new Pattern(new List<int>() { 100, 010, 001 }, 0, "Dot"));
            patterns.Add(new Pattern(new List<int>() { 100, 010, 001, 000 }, 1, "Dot With Blank"));
            patterns.Add(new Pattern(new List<int>() { 100, 110, 111, 011, 001, 000 }, 2, "Bar"));

            reversePatterns.Add(new Pattern(new List<int>() { 001, 010, 100 }, -2, "Dot (Reverse)"));//0
            reversePatterns.Add(new Pattern(new List<int>() { 001, 010, 100, 000 }, -2, "Dot With Blank (Reverse)"));//1
            reversePatterns.Add(new Pattern(new List<int>() { 001, 011, 111, 110, 100, 000 }, -2, "Bar (Reverse)"));//2

            for (int i = 0; i < patterns.Count; i++)
                patternsCollection.Items.Add(patterns[i].name);

            speedUD.Value = Properties.Settings.Default.Speed;
            repeatsUD.Value = Properties.Settings.Default.Repeats;
            patternsCollection.SelectedIndex = Properties.Settings.Default.SelectionIndex;
            continiousCB.Checked = Properties.Settings.Default.IsContinious;
            ReverseCB.Checked = Properties.Settings.Default.IsReverse;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);
        bool[] keysStartState = new bool[3];
        int lastState = 000;
        BackgroundWorker bgWorker;
        int selectedPattern;
        const int numOfItemsBeforeThePatterns = 2;//The number of things in the ComboBox before the patterns.
        private void startStopBTN_Click(object sender, EventArgs e)
        {
            if (startStopBTN.Text.Equals("Start"))
            {
                startStopBTN.Text = "Working";
                patternsCollection.Enabled = false;
                configGroup.Enabled = false;
                startStopBTN.Enabled = false;
                ReverseCB.Enabled = false;
                bgWorker = new BackgroundWorker();
                bgWorker.WorkerSupportsCancellation = true;
                bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
                bgWorker.RunWorkerAsync();
            }
        }

        void Stop()
        {
            SetKeys((keysStartState[0] ? 1 : 0) * 100 + (keysStartState[1] ? 1 : 0) * 10 + (keysStartState[2] ? 1 : 0), false);
            startStopBTN.Text = "Start";
            patternsCollection.Enabled = true;
            configGroup.Enabled = true;
            startStopBTN.Enabled = true;
            SetReverseCB();
        }

        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool[] isOn = { (((ushort)GetKeyState(0x90)) & 0xffff) != 0, (((ushort)GetKeyState(0x14)) & 0xffff) != 0, (((ushort)GetKeyState(0x91)) & 0xffff) != 0 };
            keysStartState = isOn;
            lastState = (keysStartState[0] ? 1 : 0) * 100 + (keysStartState[1] ? 1 : 0) * 10 + (keysStartState[2] ? 1 : 0);

            SetKeys(000, false);
            switch (selectedPattern)
            {
                case 0://Random
                    {
                        Random r = new Random();
                        for (int i = 0; i < (int)repeatsUD.Value * 10 || continiousCB.Checked; i++)
                            SetKeys(r.Next(2) * 100 + r.Next(2) * 10 + r.Next(2));
                    }
                    break;
                case 1://All
                    for (int k = 0; k < patterns.Count; k++)
                        for (int i = 0; i < (int)repeatsUD.Value || continiousCB.Checked; i++)
                            for (int j = 0; j < patterns[k].pattern.Count; j++)
                                SetKeys(patterns[k].pattern[j]);
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    for (int i = 0; i < (int)repeatsUD.Value || continiousCB.Checked; i++)
                        if (!ReverseCB.Checked)
                            for (int j = 0; j < patterns[selectedPattern - numOfItemsBeforeThePatterns].pattern.Count; j++)
                                SetKeys(patterns[selectedPattern - numOfItemsBeforeThePatterns].pattern[j]);
                        else
                            for (int j = 0; j < reversePatterns[patterns[selectedPattern - numOfItemsBeforeThePatterns].reverseNum].pattern.Count; j++)
                                SetKeys(reversePatterns[patterns[selectedPattern - numOfItemsBeforeThePatterns].reverseNum].pattern[j]);
                    break;
            }
            SetKeys(000, false);
        }

        void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Stop();
        }

        public void SetKeys(int keysState, bool sleep = true)
        {
            Key[] keys = new Key[3];
            keys[0] = new Key(0x90);//Num
            keys[1] = new Key(0x14);//Caps
            keys[2] = new Key(0x91);//Scroll
            bool[] isOn = { (lastState / 100 == 1), (lastState % 100 / 10 == 1), (lastState % 10 == 1) };
            bool[] wantedKeyStates = { (keysState / 100 == 1), (keysState % 100 / 10 == 1), (keysState % 10 == 1) };
            for (int i = 0; i < 3; i++)
                if (isOn[i] != wantedKeyStates[i])
                    keys[i].Toggle();
            isOn = wantedKeyStates;
            if (sleep)
                System.Threading.Thread.Sleep((11 - (int)speedUD.Value) * 100);
            lastState = keysState;
        }

        private void continiousCB_CheckedChanged(object sender, EventArgs e)
        {
            repeatsUD.Enabled = !continiousCB.Checked;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Speed = speedUD.Value;
            Properties.Settings.Default.Repeats = repeatsUD.Value;
            Properties.Settings.Default.SelectionIndex = patternsCollection.SelectedIndex;
            Properties.Settings.Default.IsContinious = continiousCB.Checked;
            Properties.Settings.Default.IsReverse = ReverseCB.Checked;
            Properties.Settings.Default.Save();
            SetKeys((keysStartState[0] ? 1 : 0) * 100 + (keysStartState[1] ? 1 : 0) * 10 + (keysStartState[2] ? 1 : 0), false);
        }

        private void patternsCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPattern = patternsCollection.SelectedIndex;
            SetReverseCB();
        }

        private void SetReverseCB()
        {
            if (selectedPattern >= 2)
                ReverseCB.Enabled = patterns[selectedPattern - numOfItemsBeforeThePatterns].reverseNum >= 0;
            else
                ReverseCB.Enabled = false;
        }
    }

    class Key
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public byte keyCode;

        public Key(byte code)
        {
            keyCode = code;
        }

        public void Toggle()
        {
            keybd_event(keyCode, 0x45, 0x1, (UIntPtr)0);
            keybd_event(keyCode, 0x45, 0x1 | 0x2, (UIntPtr)0);
        }
    }
}