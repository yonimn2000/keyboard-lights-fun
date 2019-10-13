using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public partial class PatternListForm : Form
    {
        public List<Pattern> Patterns { get; private set; }
        public int SelectedIndex { get; private set; }

        private bool hasNewChanges = false;

        public PatternListForm(IList<Pattern> patterns, int selectedIndex)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Patterns = new List<Pattern>(patterns);
            if (patterns.Count > 0)
            {
                foreach (Pattern pattern in Patterns)
                    patternsLB.Items.Add(pattern);
                patternsLB.SelectedIndex = selectedIndex;
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            PatternsFileManager.SavePatterns(Patterns);
            SelectedIndex = patternsLB.SelectedIndex;
            DialogResult = DialogResult.OK;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PatternListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hasNewChanges)
                DialogResult = DialogResult.Cancel;
            if (DialogResult != DialogResult.OK && hasNewChanges)
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
            if (patternsLB.SelectedIndex >= 0)
            {
                PatternEditorForm patternEditorForm = new PatternEditorForm(Patterns[patternsLB.SelectedIndex]);
                DialogResult patternListDialogResult = patternEditorForm.ShowDialog(this);
                if (patternListDialogResult == DialogResult.OK && patternEditorForm.HasNewChanges) // AKA "Save"
                {
                    Pattern newPattern = new Pattern(Patterns[patternsLB.SelectedIndex].Name.Equals(patternEditorForm.Pattern.Name)
                        ? patternEditorForm.Pattern.Name : GetNonDuplicatePatternName(patternEditorForm.Pattern.Name),
                        patternEditorForm.Pattern.StatesList);
                    Patterns[patternsLB.SelectedIndex] = newPattern;
                    patternsLB.Items[patternsLB.SelectedIndex] = newPattern;
                    hasNewChanges = true;
                }
                patternEditorForm.Dispose();
            }
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            if (patternsLB.SelectedIndex >= 0)
            {
                hasNewChanges = true;
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
            PatternEditorForm patternEditorForm = new PatternEditorForm(new Pattern(GetNonDuplicatePatternName("Unnamed Pattern")));
            DialogResult patternListDialogResult = patternEditorForm.ShowDialog(this);
            if (patternListDialogResult == DialogResult.OK && patternEditorForm.HasNewChanges) // AKA "Save"
            {
                Pattern newPattern = new Pattern(GetNonDuplicatePatternName(patternEditorForm.Pattern.Name), patternEditorForm.Pattern.StatesList);
                patternsLB.Items.Add(newPattern);
                Patterns.Add(newPattern);
                patternsLB.SelectedItem = newPattern;
                hasNewChanges = true;
            }
            patternEditorForm.Dispose();
        }

        private string GetNonDuplicatePatternName(string name)
        {
            string newName = name;
            int c = 1;
            while (DoesPatternNameExist(newName))
                newName = name + ' ' + c++;
            return newName;
        }

        private bool DoesPatternNameExist(string name)
        {
            foreach (Pattern pattern in Patterns)
                if (pattern.Name.Equals(name))
                    return true;
            return false;
        }

        private void patternsLB_MouseDown(object sender, MouseEventArgs e)
        {
            if (patternsLB.SelectedItem == null)
                return;
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
            hasNewChanges = true;
        }

        private void patternsLB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}