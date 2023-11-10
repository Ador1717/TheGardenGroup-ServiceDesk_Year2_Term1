namespace UI;

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
        Close();

        // Open the UserManagement form
        UserManagement userManagementForm = new UserManagement();
        userManagementForm.Show();
    }

    private void btnAddUserToDatabase_Click(object sender, EventArgs e)
    {
    }
}