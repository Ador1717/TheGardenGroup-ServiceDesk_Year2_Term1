using DAL;
using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement();
            userManagementForm.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Get the identity of the currently logged-in user 
            string userId = "your_user_id_here";

            var database = MongoDBConnection.Instance.Database;

            // Choose the MongoDB collection where user data is stored (e.g., "Users")
            var usersCollection = database.GetCollection<BsonDocument>("Users");

            try
            {
                // Define a filter to find the user based on their identity
                var filter = Builders<BsonDocument>.Filter.Eq("UserId", userId); 

                // Delete the user document from the collection
                var result = usersCollection.DeleteOne(filter);

                if (result.DeletedCount == 1)
                {
                    MessageBox.Show("User's information deleted from the MongoDB database successfully.");
                }
                else
                {
                    MessageBox.Show("User not found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
