using System.Diagnostics;
using System.Windows.Forms;

namespace N11Category
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        bool isDeveloper = false;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goUrl();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (isDeveloper || txtPassword.Text.Trim() == "123" && txtUsername.Text.Trim() == "admin")
            {
                loginPanel.Visible = false;
                menuPanel.Visible = true;
                this.Text = "Menu";
            }
            else
            {
                goUrl();
            }
        }

        private void goUrl()
        {
            string url = "https://doxalabs.co.uk";
            Process.Start(url);
        }

        private void BtnN11_Click(object sender, System.EventArgs e)
        {
            Form1 n11Form = new Form1(true);
            n11Form.Show();
        }

        private void BtnGG_Click(object sender, System.EventArgs e)
        {
            GGForm ggForm = new GGForm(true);
            ggForm.Show();
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            isDeveloper = false;
        }

        private void BtnChangeLog_Click(object sender, System.EventArgs e)
        {
            var changeLogForm = new ChangeLogForm();
            changeLogForm.Show();
        }
    }
}
