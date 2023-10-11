using Model;
using Service;

namespace UI;

public partial class Dashboard : Form
{
    private readonly TicketService _ticketService;

    public Dashboard()
    {
        InitializeComponent();
        _ticketService = new TicketService();
        UpdateOpenTicketsProgressBar();
        UpdatePastDeadlineProgressBar();
    }


    private void UpdateOpenTicketsProgressBar()
    {
        List<Ticket> allTickets = _ticketService.GetAllTickets();
        List<Ticket> openTickets = allTickets.Where(ticket => ticket.status == TicketStatus.Open).ToList();

        pbOpen.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
        pbOpen.Value = openTickets.Count;
        lblOpenTicketCount.Text = $"Open Tickets: {openTickets.Count}";
    }

    private void UpdatePastDeadlineProgressBar()
    {
        List<Ticket> pastDeadlineTickets = _ticketService.GetTicketsPastDeadline();
        List<Ticket> allTickets = _ticketService.GetAllTickets();

        pbDeadline.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
        pbDeadline.Value = pastDeadlineTickets.Count;
        lblPastDeadlineCount.Text = $"Past Deadline Tickets: {pastDeadlineTickets.Count}";
    }

    private void btnListViewDeadline_Click(object sender, EventArgs e)
    {
        ListViewForDeadlineTickets listView = new ListViewForDeadlineTickets();
        Hide();
        listView.Show();
        listView.FormClosed += (s, args) => Close();
    }

    private void btnListViewUnresolved_Click(object sender, EventArgs e)
    {
        ListViewForOpenTickets listView = new ListViewForOpenTickets();
        Hide();
        listView.Show();
        listView.FormClosed += (s, args) => Close();
    }

    private void showList_Click(object sender, EventArgs e)
    {
        TicketOverview ticketOverview = new TicketOverview();
        Hide();
        ticketOverview.Show();
        ticketOverview.FormClosed += (s, args) => Close();
    }
}