using System.Diagnostics;
using System.Windows.Forms;

namespace N11Category
{
    public partial class ChangeLogForm : Form
    {
        public ChangeLogForm()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://doxalabs.co.uk";
            Process.Start(url);
        }
    }
}
