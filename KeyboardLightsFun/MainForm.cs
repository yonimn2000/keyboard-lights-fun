using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public partial class MainForm : Form
    {
        IList<Pattern> patterns = new List<Pattern>();
        public MainForm()
        {
            InitializeComponent();
            LoadPatterns();
        }

        private void LoadPatterns()
        {
            // TODO: remove temporary
            for (int i = 0; i < 100; i++)
                patterns.Add(new Pattern("Pattern #" + i));
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
        }
    }
}