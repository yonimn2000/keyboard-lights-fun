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
            foreach (Pattern pattern in Patterns)
                patternsLB.Items.Add(pattern);
            patternsLB.SelectedIndex = 0;
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
            if (patternsLB.SelectedIndex >= 0)
            {
                PatternEditorForm patternEditorForm = new PatternEditorForm(Patterns[patternsLB.SelectedIndex]);
                DialogResult patternListDialogResult = patternEditorForm.ShowDialog(this);
                if (patternListDialogResult == DialogResult.OK) // AKA "Save"
                {
                    Patterns[patternsLB.SelectedIndex] = patternEditorForm.Pattern;
                    patternsLB.Items[patternsLB.SelectedIndex] = patternEditorForm.Pattern;
                }
                patternEditorForm.Dispose();
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {

        }

        private void patternsLB_MouseDown(object sender, MouseEventArgs e)
        {
            if (patternsLB.SelectedItem == null) return;
            patternsLB.DoDragDrop(patternsLB.SelectedItem, DragDropEffects.Move);
        }

        private void patternsLB_DragDrop(object sender, DragEventArgs e)
        {
            int index = patternsLB.IndexFromPoint(patternsLB.PointToClient(new System.Drawing.Point(e.X, e.Y)));
            if (index < 0)
                index = patternsLB.Items.Count - 1;
            Pattern data = (Pattern)e.Data.GetData(typeof(Pattern));
            Patterns.Remove(data);
            patternsLB.Items.Remove(data);
            Patterns.Insert(index, data);
            patternsLB.Items.Insert(index, data);
        }

        private void patternsLB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}