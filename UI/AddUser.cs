using Model;

namespace UI;

public partial class AddUser : Form

{
    private readonly User _user;

    public AddUser(User user)
    {
        InitializeComponent();
        _user = user;

        // Populate the UserTypeComboBox and LocationComboBox with enum values.
        /* UserTypeComboBox.DataSource = Enum.GetValues(typeof(UserType));
        LocationComboBox.DataSource = Enum.GetValues(typeof(Location)); */
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        // Close the current AddUser form
        Close();

        // Open the UserManagement form
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
    }

    private void btnAddUserToDatabase_Click(object sender, EventArgs e)
    {
    }
}