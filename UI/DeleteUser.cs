using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace UI;

public partial class DeleteUser : Form
{
    private readonly User _user;

    public DeleteUser(User user)
    {
        _user = user;
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
    }


    private void cancelButton_Click(object sender, EventArgs e)
    {
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
        Hide();
    }

    private void deleteUserButton_Click(object sender, EventArgs e)
    {
        // Get the identity of the currently logged-in user 
        string userId = "your_user_id_here";

        IMongoDatabase database = MongoDBConnection.Instance.Database;

        // Choose the MongoDB collection where user data is stored (e.g., "Users")
        IMongoCollection<BsonDocument>? usersCollection = database.GetCollection<BsonDocument>("Users");

        try
        {
            // Define a filter to find the user based on their identity
            FilterDefinition<BsonDocument>? filter = Builders<BsonDocument>.Filter.Eq("UserId", userId);

            // Delete the user document from the collection
            DeleteResult? result = usersCollection.DeleteOne(filter);

            if (result.DeletedCount == 1)
                MessageBox.Show("User's information deleted from the MongoDB database successfully.");
            else
                MessageBox.Show("User not found in the database.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }
}