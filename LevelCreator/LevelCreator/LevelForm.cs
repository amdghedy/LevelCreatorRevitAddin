using System;
using System.Windows.Forms;

namespace LevelCreator
{
    public partial class LevelForm : Form
    {
        public int NumberOfLevels { get; private set; }
        public double LevelSpacing { get; private set; }
        public string Prefix { get; private set; }
        public string Suffix { get; private set; }

        public LevelForm()
        {
            InitializeComponent();
        }

        private void btnCreateLevels_Click(object sender, EventArgs e)
        {
            NumberOfLevels = (int)numericUpDownLevels.Value;
            LevelSpacing = (double)numericUpDownSpacing.Value;
            Prefix = txtPrefix.Text;
            Suffix = txtSuffix.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
