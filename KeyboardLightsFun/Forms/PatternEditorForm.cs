using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    internal partial class PatternEditorForm : Form
    {
        public Pattern Pattern { get; private set; }

        public PatternEditorForm(Pattern pattern)
        {
            Pattern = pattern.Clone();
            InitializeComponent();
            nameTB.Text = Pattern.Name;
            foreach (ToggleableKeyStates keyStates in Pattern.StatesList)
            {
                DataGridViewRow patternGVRow = (DataGridViewRow)patternGV.Rows[0].Clone();
                patternGVRow.Cells[0].Value = keyStates.NumLockState;
                patternGVRow.Cells[1].Value = keyStates.CapsLockState;
                patternGVRow.Cells[2].Value = keyStates.ScrollLockState;
                patternGV.Rows.Add(patternGVRow);
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            SavePattern();
        }

        private void SavePattern()
        {
            UpdatePattern();
            if (nameTB.Text.Length == 0)
                MessageBox.Show("The pattern must have a name.");
            else if (Pattern.StatesList.Count == 0)
                MessageBox.Show("The pattern must have at least one key state.");
            else
                DialogResult = DialogResult.OK;
        }

        private void UpdatePattern()
        {
            Pattern.StatesList.Clear();
            foreach (DataGridViewRow row in patternGV.Rows)
                if (row.Cells[2].Value != null)
                    Pattern.StatesList.Add(new ToggleableKeyStates(
                        (bool)row.Cells[0].Value, (bool)row.Cells[1].Value, (bool)row.Cells[2].Value));
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if (nameTB.Text.Length > 0)
                Pattern.Name = nameTB.Text;
        }

        private void patternGV_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = false;
            e.Row.Cells[1].Value = false;
            e.Row.Cells[2].Value = false;
        }

        private void previewBTN_Click(object sender, EventArgs e)
        {
            if (patternPreviewBW.IsBusy)
                patternPreviewBW.CancelAsync();
            else
            {
                UpdatePattern();
                previewBTN.Text = "Stop";
                patternGV.ReadOnly = true;
                patternPreviewBW.RunWorkerAsync();
            }
        }

        private void patternPreviewBW_DoWork(object sender, DoWorkEventArgs e)
        {
            Pattern.StartShow(1000 / (int)previewSpeedNUD.Value, patternPreviewBW);
        }

        private void patternPreviewBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            patternGV.ClearSelection();
            if (e.ProgressPercentage > 0 && !patternPreviewBW.CancellationPending)
            {
                patternGV.Rows[(int)Math.Round(Pattern.StatesList.Count * (double)e.ProgressPercentage / 100) - 1].Selected = true;
                patternGV.FirstDisplayedScrollingRowIndex = patternGV.SelectedRows[0].Index;
            }
        }

        private void patternPreviewBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            previewBTN.Text = "Start";
            patternGV.ReadOnly = false;
            patternGV.ClearSelection();
        }

        private void PatternEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            patternPreviewBW.CancelAsync();
            if (DialogResult != DialogResult.OK)
            {
                DialogResult closeDialogResult = MessageBox.Show("Do you want to save the changes?", "Warning",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (closeDialogResult)
                {
                    case DialogResult.Cancel: e.Cancel = true; break;
                    case DialogResult.Yes: SavePattern(); break;
                    case DialogResult.No: DialogResult = DialogResult.Cancel; break;
                }
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}