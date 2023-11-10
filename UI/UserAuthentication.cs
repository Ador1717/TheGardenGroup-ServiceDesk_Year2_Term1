using MongoDB.Driver;
using Model;
using System.Windows.Forms;
using Service;
using System.Text;

namespace UI
{
    public partial class UserAuthentication : Form
    {

        Autentication autentication;
        public UserAuthentication()
        {
            autentication = new Autentication();
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password  = textBoxPassword.Text;

            User user = autentication.AutenticateUser(username, password);

            if (user == null)
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }


            this.Hide();
            new Dashboard(user).Show();
            

        }

        // TODO: change label name
        private void RestPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = textBoxUserName.Text;
            if (username == "")
            {
                MessageBox.Show("Please enter the username for which you want to reset the password");
                return;
            }

            User user = autentication.GetUserForForgetPassword(username);
            this.Hide();
            new ResetPassword(user).Show();
        }

        private void UserAuthentication_Load(object sender, EventArgs e)
        {

        }

        private void Show_HidePass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = Show_HidePass.Checked;
            Show_HidePass.Text = Show_HidePass.Checked ? "hide" : "show";
        }

    }
}