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
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Show(this);
    }

    private void btnShowlist_Click(object sender, EventArgs e)
    {
        TicketOverview ticketOverview = new TicketOverview();
        Hide();
        ticketOverview.Show();
        ticketOverview.FormClosed += (s, args) => Close();
    }


    private void pBUnresolvedTickets_Click(object sender, EventArgs e)
    {
        List<Ticket> openTickets = _ticketService.GetTicketsByStatus(TicketStatus.Open);
        List<Ticket> allTickets = _ticketService.GetAllTickets();

        pBUnresolvedTickets.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
        pBUnresolvedTickets.Value = Math.Min(openTickets.Count, pBUnresolvedTickets.Maximum);

        lblOpenTicketCount.Text = $"Open Tickets: {openTickets.Count}";
    }

    private void pBPastDeadline_Click(object sender, EventArgs e)
    {
        List<Ticket> pastDeadlineTickets = _ticketService.GetTicketsPastDeadline();
        List<Ticket> allTickets = _ticketService.GetAllTickets();

        pBPastDeadline.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
        pBPastDeadline.Value = Math.Min(pastDeadlineTickets.Count, pBPastDeadline.Maximum);

        lblPastDeadlineCount.Text = $"Past Deadline Tickets: {pastDeadlineTickets.Count}";
    }
}