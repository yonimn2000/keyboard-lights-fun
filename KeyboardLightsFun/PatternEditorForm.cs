using System;
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
            UpdatePattern();
            DialogResult = DialogResult.OK;
        }

        private void UpdatePattern()
        {
            Pattern.StatesList.Clear();
            foreach (DataGridViewRow row in patternGV.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    ToggleableKeyStates toggleableKeyStates = new ToggleableKeyStates(
                                (bool)row.Cells[0].Value, (bool)row.Cells[1].Value, (bool)row.Cells[2].Value);
                    Pattern.StatesList.Add(toggleableKeyStates);
                }
            }
        }

        private void previewBTN_Click(object sender, EventArgs e)
        {
            UpdatePattern();
            Pattern.StartShow((int)previewSpeedNUD.Value * 100);
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
    }
}