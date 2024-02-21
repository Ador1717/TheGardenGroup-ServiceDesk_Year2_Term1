using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using Service;
using Services;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace UI;

public partial class UserManagement : Form
{
    private readonly TicketService _ticketService;
    private readonly User _user;
    private readonly UserService _userService;


    public UserManagement(User user)
    {
        _user = user;
        InitializeComponent();
        _ticketService = new TicketService();
        _userService = new UserService();
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        InitializeListView();
        LoadUserData();
        label2.Text = user.email;
    }

    private void InitializeListView()
    {
        // Set the ListView to Details view
        listviewUsermanagement.View = View.Details;

        // Add columns to the ListView
        listviewUsermanagement.Columns.Add("", 0);
        listviewUsermanagement.Columns.Add("Email", 150);
        listviewUsermanagement.Columns.Add("Username", 100);
        listviewUsermanagement.Columns.Add("First Name", 100);
        listviewUsermanagement.Columns.Add("Last Name", 100);
        listviewUsermanagement.Columns.Add("Location", 80);
    }

    private void LoadUserData()
    {
        listviewUsermanagement.Items.Clear();
        listviewUsermanagement.FullRowSelect = true;

        IEnumerable<User> users = _userService.GetAllUsers();
        int userCounter = 1;

        // Format and display data in ListView or other control.
        foreach (User user in users)
        {
            ListViewItem item = new ListViewItem(userCounter.ToString());
            item.Tag = user.userId.ToString();


            item.SubItems.Add(user.email);
            item.SubItems.Add(user.username);
            item.SubItems.Add(user.firstName);
            item.SubItems.Add(user.lastName);
            item.SubItems.Add(user.location);
            listviewUsermanagement.Items.Add(item);

            userCounter++;
        }
    }


    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard(_user);
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }

    private void btnMenuIncidentManagement_Click(object sender, EventArgs e)
    {
       TicketOverview ticketOverview = new TicketOverview(_user);
        ticketOverview.Show();
        Hide();
        ticketOverview.FormClosed += (s, args) => Close();
    }

    private void btnAddNewUser_Click(object sender, EventArgs e)
    {
        AddUser addUserForm = new AddUser(_user);
        addUserForm.Show();
        Hide();
        addUserForm.FormClosed += (s, args) => Close();
    }


    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
        DeleteSelectedTicket();
    }

    private void DeleteSelectedTicket()
    {
        if (listviewUsermanagement.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a user to delete.");
            return;
        }

        // Check if the current user is a manager or service desk user
        if (_user.userType == UserType.Manager || _user.userType == UserType.ServiceDeskUser)
        {
            var selectedUser = listviewUsermanagement.SelectedItems[0];
            var userIdString = selectedUser.Tag.ToString();

            if (!ObjectId.TryParse(userIdString, out ObjectId userId))
            {
                MessageBox.Show("Invalid user ID.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                PerformDeleteOperation(userId);
            }
        }
        else
        {
            MessageBox.Show("You do not have permission to delete users.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void PerformDeleteOperation(ObjectId userId)
    {
        try
        {
            _userService.DeleteUser(userId); // Assuming such a method exists
            MessageBox.Show("User deleted successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error deleting user: " + ex.Message);
        }

        // Update the ListView
        LoadUserData();
    }

    private void btnUserManagement_Click(object sender, EventArgs e)
    {
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
        userManagementForm.FormClosed += (s, args) => Close();
    }
}