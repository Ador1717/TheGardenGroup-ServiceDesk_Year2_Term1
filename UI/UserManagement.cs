using DAL;
using Model;
using Service;
using Services;
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
    public partial class UserManagement : Form
    {
        private readonly TicketService _ticketService;
        private readonly UserService _userService;

        public UserManagement()
        {
            InitializeComponent();
            _ticketService = new TicketService();
            _userService = new UserService();
            InitializeListView();
            LoadUserData();
        }

        private void InitializeListView()
        {
            // Set the ListView to Details view
            listviewUsermanagement.View = View.Details;

            // Add columns to the ListView
            listviewUsermanagement.Columns.Add("ID", 60);
            listviewUsermanagement.Columns.Add("Email", 150);
            listviewUsermanagement.Columns.Add("First Name", 100);
            listviewUsermanagement.Columns.Add("Last Name", 100);
            listviewUsermanagement.Columns.Add("Location", 80);
        }
        
        
        private void LoadUserData()
        {
            listviewUsermanagement.Items.Clear();

            IEnumerable<User> users = _userService.GetAllUsers();

            // Format and display data in ListView or other control.
            foreach (User user in users)
            {
                ListViewItem item = new ListViewItem(user.ID);
                item.Tag = user.ID;

                item.SubItems.Add(user.ID);
                item.SubItems.Add(user.email);
                item.SubItems.Add(user.firstName);
                item.SubItems.Add(user.lastName);
                item.SubItems.Add(user.location);
                listviewUsermanagement.Items.Add(item);
            }
        } 
        

        private void txtBoxFilterEmail_TextChanged(object sender, EventArgs e)
        {
            FilterUsers(txtBoxFilterEmail.Text);
        }


        private void FilterUsers(string emailFilter)
        {
            listviewUsermanagement.Items.Clear();

            IEnumerable<User> users = _userService.GetAllUsers();

            // Filter the users based on the emailFilter.
            IEnumerable<User> filteredUsers = users.Where(u =>
                u.email != null &&
                u.email.Contains(emailFilter, StringComparison.OrdinalIgnoreCase));

            foreach (User user in filteredUsers)
            {
                ListViewItem item = new ListViewItem(user.ID);
                item.Tag = user.ID;

                item.SubItems.Add(user.email);
                item.SubItems.Add(user.firstName);
                item.SubItems.Add(user.lastName);
                item.SubItems.Add(user.location);
                listviewUsermanagement.Items.Add(item);
            }
        }


        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            Hide();
            dashboard.Show();
            dashboard.FormClosed += (s, args) => Close();
        }

        private void btnMenuIncidentManagement_Click(object sender, EventArgs e)
        {
            CreateTicket create = new CreateTicket();
            Hide();
            create.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUserForm = new DeleteUser();
            deleteUserForm.Show();
        }
    }
}
