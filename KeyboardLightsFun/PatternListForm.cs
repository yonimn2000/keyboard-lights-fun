using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    internal partial class PatternListForm : Form
    {
        public IList<Pattern> Patterns { get; private set; }

        internal PatternListForm(IList<Pattern> patterns)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Patterns = new List<Pattern>(patterns);
            foreach (Pattern pattern in patterns)
                patternsLB.Items.Add(pattern.Name);
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            ConfirmClosing();
        }

        private void PatternListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmClosing();
            //e.Cancel = true;
        }

        private void ConfirmClosing()
        {
            /*if (isSaved||DialogResult.Yes == MessageBox.Show("Are you sure you want to close without saving?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                Close();*/
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            EditSelectedPattern();
        }

        private void EditSelectedPattern()
        {
            if (patternsLB.SelectedIndex >= 0)
            {
                PatternEditorForm patternEditorForm = new PatternEditorForm(Patterns[patternsLB.SelectedIndex]);
                DialogResult patternListDialogResult = patternEditorForm.ShowDialog(this);
                if (patternListDialogResult == DialogResult.OK) // AKA "Save"
                {
                    Patterns[patternsLB.SelectedIndex] = patternEditorForm.Pattern;
                    patternsLB.Items[patternsLB.SelectedIndex] = patternEditorForm.Pattern.Name;
                }
                patternEditorForm.Dispose();
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {

        }

        private void patternsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patternsLB.SelectedIndex >= 0)
                editBTN.Enabled = true;
        }

        private void patternsLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (patternsLB.IndexFromPoint(e.Location) >= 0)
                EditSelectedPattern();
        }
    }
}