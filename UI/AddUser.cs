﻿using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using Service;

namespace UI;

public partial class AddUser : Form

{
    private readonly User _user;

    public AddUser(User user)
    {
        InitializeComponent();
        _user = user;
        comboBox1.DataSource = Enum.GetValues(typeof(UserType));
        comboBox2.DataSource = Enum.GetValues(typeof(Location));
        label9.Text = user.email;
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
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
        string username = usernameTextbox.Text;
        string password = passwordTextbox.Text;

        // Ensure that the fields are not empty
        if (string.IsNullOrEmpty(firstName) ||
            string.IsNullOrEmpty(lastName) ||
            string.IsNullOrEmpty(email) ||
            string.IsNullOrEmpty(phoneNumber) ||
            string.IsNullOrEmpty(userType) ||
            string.IsNullOrEmpty(location) ||
            string.IsNullOrEmpty(username) ||
            string.IsNullOrEmpty(password)
            )
        {
            MessageBox.Show("Please fill in all the fields.");
            return;
        }

        string salt = HashUtil.GenerateSalt();
        string hashedPassword = HashUtil.HashPassword(password, salt);

        // Create a new user document to insert into the MongoDB collection
        BsonDocument userDocument = new BsonDocument
        {
            { "firstName", firstName },
            { "lastName", lastName },
            { "userType", userType },
            { "email", email },
            { "phone", phoneNumber },
            { "location", location },
            { "hashedPassword", hashedPassword },
            { "username", username },
            { "salt", salt }
        };

        // Get the MongoDB database instance from your MongoDBConnection Singleton
        IMongoDatabase database = MongoDBConnection.Instance.Database;

        // Choose the MongoDB collection where you want to insert the user data
        IMongoCollection<BsonDocument>? usersCollection = database.GetCollection<BsonDocument>("Users");

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

    /*
    private void btnCancel_Click(object sender, EventArgs e)
    {
        // Close the current AddUser form
        Close();

        // Open the UserManagement form
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
        Hide();
        userManagementForm.FormClosed += (s, args) => Close();
    } */

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

    private void btnUserManagement_Click(object sender, EventArgs e)
    {
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
        Hide();
        userManagementForm.FormClosed += (s, args) => Close();
    }

    private void btnCancel_Click_1(object sender, EventArgs e)
    {
        // Close the current AddUser form
        Close();

        // Open the UserManagement form
        UserManagement userManagementForm = new UserManagement(_user);
        userManagementForm.Show();
        Hide();
        userManagementForm.FormClosed += (s, args) => Close();
    }
}