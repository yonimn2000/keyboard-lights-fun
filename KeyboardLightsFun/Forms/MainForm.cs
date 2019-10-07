using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public partial class MainForm : Form
    {
        private List<Pattern> patterns = new List<Pattern>();
        private PatternShowController patternShowController;

        public MainForm()
        {
            InitializeComponent();
            PatternsFileManager.LoadPatterns(ref patterns);
            UpdatePatternsComboBox();
        }

        private void UpdatePatternsComboBox()
        {
            patternsCB.Items.Clear();
            if (patterns.Count > 0)
            {
                foreach (Pattern pattern in patterns)
                    patternsCB.Items.Add(pattern);
                patternsCB.SelectedIndex = 0;
            }
        }

        private void ContiniousCB_CheckedChanged(object sender, EventArgs e)
        {
            repeatsNUD.Enabled = !continiousCB.Checked;
        }

        private void patternEditBTN_Click(object sender, EventArgs e)
        {
            PatternListForm patternListForm = new PatternListForm(patterns);
            DialogResult patternListDialogResult = patternListForm.ShowDialog(this);
            if (patternListDialogResult == DialogResult.OK) // AKA "Save"
                patterns = patternListForm.Patterns;
            patternListForm.Dispose();
            UpdatePatternsComboBox();
        }

        private void startStopBTN_Click(object sender, EventArgs e)
        {
            if (patternShowController != null && patternShowController.IsShowing())
                patternShowController.EndShow();
            else
            {
                startStopBTN.Text = "Stop";
                patternShowController = new PatternShowController(new PatternShow((Pattern)patternsCB.SelectedItem), (int)speedNUD.Value);
                patternShowController.ProgressReported += PatternShowController_ProgressReported;
                patternShowController.ShowEnded += PatternShowController_ShowEnded;
                patternShowController.StartShow();
            }
        }

        private void PatternShowController_ShowEnded(object sender, EventArgs e)
        {
            startStopBTN.Invoke(new MethodInvoker(delegate { startStopBTN.Text = "Start"; }));
            toggeableKeyStatesVisualizer.Invoke(new MethodInvoker(
                    delegate { toggeableKeyStatesVisualizer.MakeInactive(); }));
        }

        private void PatternShowController_ProgressReported(object sender, ShowProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0)
            {
                patternShowPB.Invoke(new MethodInvoker(delegate { patternShowPB.Value = e.ProgressPercentage; }));
                toggeableKeyStatesVisualizer.Invoke(new MethodInvoker(
                    delegate { toggeableKeyStatesVisualizer.Set(e.CurrentToggleableKeyStates); }));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            patternShowController.EndShow();
        }
    }
}