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
            IEnumerable<Ticket> openTickets = _ticketService.GetOpenTicketsUsingAggregation();
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
                ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
                item.SubItems.Add(ticket.reportedByUser);
                item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
                item.SubItems.Add(ticket.status.ToString());
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
                new ColumnHeader { Text = @"Name", Width = 100 },
                new ColumnHeader { Text = @"Date & Time Reported", Width = 200 },
                new ColumnHeader { Text = @"Status", Width = 100 }
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