using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

            // Populate the UserTypeComboBox and LocationComboBox with enum values.
            /* UserTypeComboBox.DataSource = Enum.GetValues(typeof(UserType));
            LocationComboBox.DataSource = Enum.GetValues(typeof(Location)); */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the current AddUser form
            this.Close();

            // Open the UserManagement form
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();
        }

        private void btnAddUserToDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
