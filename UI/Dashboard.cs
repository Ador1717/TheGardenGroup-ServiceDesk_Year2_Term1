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


    private void pBUnresolvedTickets_Click_1(object sender, EventArgs e)
    {
        try
        {
            // U need to change this so its a bit more elaborate use a query that searches for tickets with a certain status do for the other progress bar
            List<Ticket> allTickets = _ticketService.GetAllTickets();
            List<Ticket> openTickets = new List<Ticket>();

            foreach (Ticket ticket in allTickets)
                if (ticket.status == TicketStatus.Open)
                    openTickets.Add(ticket);

            pBUnresolvedTickets.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
            pBUnresolvedTickets.Value = Math.Min(openTickets.Count, pBUnresolvedTickets.Maximum);
            lblOpenTicketCount.Text = $"Open Tickets: {openTickets.Count}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void pBPastDeadline_Click_1(object sender, EventArgs e)
    {
        try
        {
            List<Ticket> pastDeadlineTickets = _ticketService.GetTicketsPastDeadline();
            List<Ticket> allTickets = _ticketService.GetAllTickets();
            pBPastDeadline.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
            pBPastDeadline.Value = Math.Min(pastDeadlineTickets.Count, pBPastDeadline.Maximum);
            lblPastDeadlineCount.Text = $"Past Deadline Tickets: {pastDeadlineTickets.Count}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnShowlist_Click_1(object sender, EventArgs e)
    {
        TicketOverview ticketOverview = new TicketOverview();
        Hide();
        ticketOverview.Show();
        ticketOverview.FormClosed += (s, args) => Close();
    }
}