using Microsoft.VisualBasic.ApplicationServices;
using Model;
using MongoDB.Bson;
using Service;
using Services;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace UI;

public partial class TicketOverview : Form
{
    private readonly TicketService _ticketService;
    private readonly UserService _userService;
    private readonly Model.User user;

    public TicketOverview(Model.User user)
    {
        InitializeComponent();
        _ticketService = new TicketService();
        _userService = new UserService();
        this.user = user;
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        LoadTicketData();
        label2.Text = user.email;
    }

    private void LoadTicketData()
    {
        try
        {
            IEnumerable<Ticket> openTickets;

            // Check if the user is a manager
            if (user.userType == UserType.Manager || user.userType == UserType.ServiceDeskUser)
                // If the user is a Manager, get all open tickets
                openTickets = _ticketService.GetAllTickets().Where(t => t.status == TicketStatus.Open);
            else
                // For other users, get open tickets specific to them
                openTickets = _ticketService.GetOpenTicketsUsingAggregation(user.firstName.ToLower())
                    .Where(t => t.reportedByUser.Equals(user.firstName, StringComparison.OrdinalIgnoreCase));

            populateTable(openTickets);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while loading open tickets: " + ex.Message);
        }
    }

    public void populateTable(IEnumerable<Ticket> tickets)
    {
        try
        {
            listviewTicketOverview.Items.Clear();
            int ticketCounter = 1; // Start a counter for the ticket ID
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticketCounter.ToString()); // Use the counter as the ID
                item.Tag = ticket.ticketId.ToString(); // Keep the actual database ID in the Tag property if needed

                string userEmail = ticket.UserDetails?.Email ?? "Not Available";
                item.SubItems.Add(userEmail);
                item.SubItems.Add(ticket.reportedByUser);
                item.SubItems.Add(ticket.subject);
                item.SubItems.Add(ticket.priorityEnum.ToString());
                item.SubItems.Add(ticket.status.ToString());
                item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));

                listviewTicketOverview.Items.Add(item);

                ticketCounter++; // Increment the counter for each ticket
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while populating the list view: " + ex.Message);
        }

    }
    private void TicketOverview_Load(object sender, EventArgs e)
    {
        listviewTicketOverview.GridLines = true;
        listviewTicketOverview.FullRowSelect = true;
        listviewTicketOverview.View = View.Details;
        listviewTicketOverview.Columns.Add("_Id", 50, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("SubjectEmail", 175, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("username", 80, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("Subject", 80, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("Priority", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("Status", 80, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("dateTimeReported", 150, HorizontalAlignment.Left);
        LoadTicketData();
    }

    private void txtBoxFilterEmail_TextChanged(object sender, EventArgs e)
    {
        FilterTickets(txtBoxFilterEmail.Text);
    }

    private void FilterTickets(string emailFilter)
    {
        listviewTicketOverview.Items.Clear();

        if (string.IsNullOrEmpty(emailFilter))
        {
            // If no email filter is provided, load all tickets
            LoadTicketData();
            return;
        }

        // Retrieve tickets for the specified email from the database
        IEnumerable<Ticket> filteredTickets = _ticketService.GetTicketsByReporterEmail(emailFilter);

        // Display the filtered tickets
        populateTable(filteredTickets);
    }

    private void btnCreateIncident_Click(object sender, EventArgs e)
    {
        CreateTicket create = new CreateTicket(user);
        create.ShowDialog();
        //Hide();
      //  create.FormClosed += (s, args) => Close();
        LoadTicketData();
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard(user);
        dashboard.Show();
        Hide();
        dashboard.FormClosed += (s, args) => Close();
    }

    private void btnUserManagement_Click(object sender, EventArgs e)
    {
        UserManagement userManagementForm = new UserManagement(user);
        userManagementForm.Show();
        Hide();
        userManagementForm.FormClosed += (s, args) => Close();
    }

    private void Delete_incident_Click(object sender, EventArgs e)
    {
        DeleteSelectedTicket();
    }
    private void DeleteSelectedTicket()
    {
        if (listviewTicketOverview.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a ticket to delete.");
            return;
        }

        var selectedTicket = listviewTicketOverview.SelectedItems[0];
        var ticketIdString = selectedTicket.Tag.ToString();

        if (!ObjectId.TryParse(ticketIdString, out ObjectId ticketId))
        {
            MessageBox.Show("Invalid ticket ID.");
            return;
        }

        var confirmResult = MessageBox.Show("Are you sure to delete this ticket?", "Confirm Delete", MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
            PerformDeleteOperation(ticketId);
        }
    }

    private void PerformDeleteOperation(ObjectId ticketId)
    {
        try
        {
            _ticketService.DeleteTicket(ticketId); // Assuming such a method exists
            MessageBox.Show("Ticket deleted successfully.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error deleting ticket: " + ex.Message);
        }

        // Update the ListView
        LoadTicketData();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        EditSelectedTicket();
    }
    private void EditSelectedTicket()
    {
        if (listviewTicketOverview.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a ticket to edit.");
            return;
        }

        var selectedTicket = listviewTicketOverview.SelectedItems[0];
        var ticketIdString = selectedTicket.Tag.ToString();

        if (!ObjectId.TryParse(ticketIdString, out ObjectId ticketId))
        {
            MessageBox.Show("Invalid ticket ID.");
            return;
        }

        // Retrieve the selected ticket details
        Ticket ticketToEdit = _ticketService.GetTicketById(ticketId);

        if (ticketToEdit == null)
        {
            MessageBox.Show("Ticket not found.");
            return;
        }

        // Open the ticket edit form/dialog
        EditTicket editForm = new EditTicket(ticketToEdit);
        editForm.ShowDialog();

        // Refresh the ListView after editing
        LoadTicketData();
    }

}