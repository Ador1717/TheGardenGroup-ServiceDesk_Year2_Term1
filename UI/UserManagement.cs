using Model;
using Service;
using Services;

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
        listviewUsermanagement.Columns.Add("ID", 60);
        listviewUsermanagement.Columns.Add("Email", 150);
        listviewUsermanagement.Columns.Add("First Name", 100);
        listviewUsermanagement.Columns.Add("Last Name", 100);
    }


    private void LoadUserData()
    {
        listviewUsermanagement.Items.Clear();

        IEnumerable<User> users = _userService.GetAllUsers();

        // Format and display data in ListView or other control.
        foreach (User user in users)
        {
            ListViewItem item = new ListViewItem(user.ID);

            //item.SubItems.Add(user.ID);
            item.SubItems.Add(user.email);
            item.SubItems.Add(user.firstName);
            item.SubItems.Add(user.lastName);
            listviewUsermanagement.Items.Add(item);
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
        CreateTicket create = new CreateTicket(_user);
        create.Show();
        Hide();
        create.FormClosed += (s, args) => Close();
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
        DeleteUser deleteUserForm = new DeleteUser(_user);
        deleteUserForm.Show();
        deleteUserForm.FormClosed += (s, args) => Close();
    }

    private void btnUserManagement_Click(object sender, EventArgs e)
    {
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
        userManagementForm.FormClosed += (s, args) => Close();
    }
}