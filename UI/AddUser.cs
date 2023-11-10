using DAL;
using Model;
using MongoDB.Bson;
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
            comboBox1.DataSource = Enum.GetValues(typeof(UserType));
            comboBox2.DataSource = Enum.GetValues(typeof(Location));
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
            // Get user input from the form fields
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string userType = comboBox1.SelectedItem.ToString();
            string email = textBox4.Text;
            string phoneNumber = textBox5.Text;
            string location = comboBox2.SelectedItem.ToString();

            // Ensure that the fields are not empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(userType) || string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Create a new user document to insert into the MongoDB collection
            var userDocument = new BsonDocument
            {
                { "firstName", firstName },
                { "lastName", lastName },
                { "userType", userType.ToString() },
                { "email", email },
                { "phone", phoneNumber },
                { "location", location }
            };

            // Get the MongoDB database instance from your MongoDBConnection Singleton
            var database = MongoDBConnection.Instance.Database;

            // Choose the MongoDB collection where you want to insert the user data
            var usersCollection = database.GetCollection<BsonDocument>("Users");

            try
            {
                // Insert the user document into the collection
                usersCollection.InsertOne(userDocument);

                MessageBox.Show("User added to the database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
