using System.Collections.Generic;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    internal partial class PatternListForm : Form
    {
        public IList<Pattern> Patterns { get; private set; }

        private bool isSaved = true;

        internal PatternListForm(IList<Pattern> patterns)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Patterns = new List<Pattern>(patterns);
            foreach (Pattern pattern in patterns)
                patternsLB.Items.Add(pattern);
        }

        private void removeBTN_Click(object sender, System.EventArgs e)
        {
            isSaved = false;
        }

        private void saveBTN_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            isSaved = true;
            Close();
        }

        private void cancelBTN_Click(object sender, System.EventArgs e)
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

        private void editBTN_Click(object sender, System.EventArgs e)
        {
            isSaved = false;
        }

        private void addBTN_Click(object sender, System.EventArgs e)
        {
            isSaved = false;
        }
    }
}