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
            string userName = textBoxUserName.Text;
            string password  = textBoxPassword.Text;

            if (!autentication.AutenticateUser(userName, password))
            {
                MessageBox.Show("invalid credentials");
                return;
            } 
            
            
            
            MessageBox.Show(userName);
        }
    }
}