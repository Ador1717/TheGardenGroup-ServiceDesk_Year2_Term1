using Model;
using Service;
using Services;

namespace UI;

public partial class TicketOverview : Form
{
    private readonly TicketService _ticketService;
    private readonly UserService _userService;
    private readonly User user;
    public TicketOverview(User user)
    {
        InitializeComponent();
        _ticketService = new TicketService();
        _userService = new UserService();
        LoadTicketData();
        this.user = user;
    }

    private void LoadTicketData()
    {
        listviewTicketOverview.Items.Clear();

        IEnumerable<Ticket> tickets = _ticketService.GetAllTickets();

        // Format and display data in ListView or other control.
        foreach (Ticket ticket in tickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();

            string userEmail = ticket.UserDetails?.Email ?? "Not Available"; // Handle null UserDetails
            item.SubItems.Add(userEmail);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listviewTicketOverview.Items.Add(item);
        }
    }

    private void TicketOverview_Load(object sender, EventArgs e)
    {
        listviewTicketOverview.GridLines = true;
        listviewTicketOverview.FullRowSelect = true;
        listviewTicketOverview.View = View.Details;
        listviewTicketOverview.Columns.Add("_Id", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("SubjectEmail", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("username", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("dateTimeReported", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("Status", 100, HorizontalAlignment.Left);
        LoadTicketData();
    }

    private void txtBoxFilterEmail_TextChanged(object sender, EventArgs e)
    {
        FilterTickets(txtBoxFilterEmail.Text);
    }

    private void FilterTickets(string emailFilter)
    {
        listviewTicketOverview.Items.Clear();
       
        // Retrieve all tickets
        IEnumerable<Ticket> tickets = _ticketService.GetAllTickets();

        // Filter tickets based on the email
        IEnumerable<Ticket> filteredTickets = tickets.Where(ticket => ticket.UserDetails.Email.Contains(emailFilter, StringComparison.OrdinalIgnoreCase));

        // Display the filtered tickets
        foreach (var ticket in filteredTickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();

            item.SubItems.Add(ticket.UserDetails.Email);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listviewTicketOverview.Items.Add(item);
        }

    }

    private void btnCreateIncident_Click(object sender, EventArgs e)
    {
        CreateTicket create = new CreateTicket(user);
        create.ShowDialog();
        LoadTicketData();
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard(user);
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }
}