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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.autentication.ResetPassword("hi");
        }
    }
}