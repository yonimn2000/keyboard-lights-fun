using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public partial class MainForm : Form
    {
        IList<Pattern> patterns = new List<Pattern>();
        public MainForm()
        {
            InitializeComponent();
            PatternsFileManager.LoadPatterns(patterns);
            UpdatePatternsComboBox();
        }

        private void UpdatePatternsComboBox()
        {
            patternsCB.Items.Clear();
            foreach (Pattern pattern in patterns)
                patternsCB.Items.Add(pattern);
            patternsCB.SelectedIndex = 0;
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
            patternShowBW.RunWorkerAsync(patternsCB.SelectedIndex);
        }

        private void patternShowBW_DoWork(object sender, DoWorkEventArgs e)
        {
            patterns[(int)e.Argument].StartShow(1000 / (int)speedNUD.Value, patternShowBW);
        }

        private void patternShowBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            patternShowPB.Value = e.ProgressPercentage;
        }

        private void patternShowBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            patternShowBW.CancelAsync();
        }
    }
}