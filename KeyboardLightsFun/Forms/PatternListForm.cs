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

        private void saveBTN_Click(object sender, EventArgs e)
        {
            PatternsFileManager.SavePatterns(Patterns);
            DialogResult = DialogResult.OK;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PatternListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult closeDialogResult = MessageBox.Show("Do you want to save the changes?", "Warning",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (closeDialogResult)
                {
                    case DialogResult.Cancel: e.Cancel = true; break;
                    case DialogResult.Yes: DialogResult = DialogResult.OK; break;
                    case DialogResult.No: DialogResult = DialogResult.Cancel; break;
                }
            }
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
                    patternsLB.Items[patternsLB.SelectedIndex] = patternEditorForm.Pattern;
                }
                patternEditorForm.Dispose();
            }
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            if (patternsLB.SelectedIndex >= 0)
            {
                Patterns.RemoveAt(patternsLB.SelectedIndex);
                int currentSelectedIndex = patternsLB.SelectedIndex;
                patternsLB.Items.RemoveAt(patternsLB.SelectedIndex);
                if (currentSelectedIndex == patternsLB.Items.Count)
                    patternsLB.SelectedIndex = currentSelectedIndex - 1;
                else
                    patternsLB.SelectedIndex = currentSelectedIndex;
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Pattern pattern = new Pattern("Unnamed pattern");
            patternsLB.Items.Add(pattern);
            Patterns.Add(pattern);
            patternsLB.SelectedItem = pattern;
            EditSelectedPattern();
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