using Model;
using Service;
using Services;

namespace UI;

public partial class UserManagement : Form
{
    private readonly TicketService _ticketService;
    private readonly UserService _userService;

    public UserManagement()
    {
        InitializeComponent();
        _ticketService = new TicketService();
        _userService = new UserService();
        LoadTicketData();
    }

    private void LoadTicketData()
    {
        listviewUsermanagement.Items.Clear();

        IEnumerable<Ticket> tickets = _ticketService.GetAllTickets();

        // Format and display data in ListView or other control.
        foreach (Ticket ticket in tickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();

            item.SubItems.Add(ticket.email);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listviewUsermanagement.Items.Add(item);
        }
    }

    private void txtBoxFilterEmail_TextChanged(object sender, EventArgs e)
    {
        FilterTickets(txtBoxFilterEmail.Text);
    }

    private void FilterTickets(string emailFilter)
    {
        listviewUsermanagement.Items.Clear();

        IEnumerable<Ticket> tickets = _ticketService.GetAllTickets();

        // Filter the tickets based on the emailFilter.
        IEnumerable<Ticket> filteredTickets = tickets.Where(t =>
            t.email != null &&
            t.email.Contains(emailFilter, StringComparison.OrdinalIgnoreCase));
        foreach (Ticket ticket in filteredTickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();

            item.SubItems.Add(ticket.email);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listviewUsermanagement.Items.Add(item);
        }
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard();
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }

    private void btnMenuIncidentManagement_Click(object sender, EventArgs e)
    {
        CreateTicket create = new CreateTicket();
        Hide();
        create.ShowDialog();
    }

    private void btnAddNewUser_Click(object sender, EventArgs e)
    {
        AddUser addUserForm = new AddUser();
        addUserForm.Show();
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
    }
}