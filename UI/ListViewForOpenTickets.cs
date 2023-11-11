using Model;
using Service;

namespace UI;

public partial class ListViewForOpenTickets : Form
{
    private readonly TicketService _ticketService;
    private readonly User _user;

    public ListViewForOpenTickets(User user)
    {
        try
        {
            // Loads ticket information and loads them into the list view
            InitializeComponent();
            _ticketService = new TicketService();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _user = user;
            ConfigureListView();
            LoadTickets();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred during initialization: " + ex.Message);
        }
    }

    // Loads tickets into the list 
    private void LoadTickets()
    {
        try
        {
            IEnumerable<Ticket> openTickets;

            // Check if the user is a manager
            if (_user.userType == UserType.Manager || _user.userType == UserType.ServiceDeskUser)
                // If the user is a Manager, get all open tickets
                openTickets = _ticketService.GetAllTickets().Where(t => t.status == TicketStatus.Open);
            else
                // For other users, get open tickets specific to them
                openTickets = _ticketService.GetOpenTicketsUsingAggregation(_user.firstName.ToLower())
                    .Where(t => t.reportedByUser.Equals(_user.firstName, StringComparison.OrdinalIgnoreCase));

            PopulateListView(openTickets);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while loading open tickets: " + ex.Message);
        }
    }


    // Populates list view with the list of tickets 
    private void PopulateListView(IEnumerable<Ticket> tickets)
    {
        try
        {
            listViewTickets.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.ticketId.ToString())
                {
                    SubItems =
                    {
                        ticket.reportedByUser,
                        ticket.subject,
                        ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"),
                        ticket.status.ToString(),
                        ticket.priorityEnum.ToString(),
                        ticket.typeOfIncidentEnum.ToString()
                    }
                };
                listViewTickets.Items.Add(item);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while populating the list view: " + ex.Message);
        }
    }

    // Configures the format of the list view
    private void ConfigureListView()
    {
        try
        {
            listViewTickets.GridLines = true;
            listViewTickets.FullRowSelect = true;
            listViewTickets.View = View.Details;

            listViewTickets.Columns.AddRange(new[]
            {
                new ColumnHeader { Text = @"Id", Width = 100 },
                new ColumnHeader { Text = @"Name", Width = 120 },
                new ColumnHeader { Text = @"Subject", Width = 100 },
                new ColumnHeader { Text = @"Date & Time Reported", Width = 160 },
                new ColumnHeader { Text = @"Status", Width = 90 },
                new ColumnHeader { Text = @"Priority", Width = 90 }
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while configuring the list view: " + ex.Message);
        }
    }

    // Goes back to dashboard view 
    private void btnGoBack_Click(object sender, EventArgs e)
    {
        try
        {
            Dashboard dashboard = new Dashboard(_user);
            Hide();
            dashboard.Show();
            dashboard.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while returning to the dashboard: " + ex.Message);
        }
    }
}