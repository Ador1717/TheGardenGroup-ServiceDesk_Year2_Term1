using Model;
using Service;

namespace UI;

public partial class Dashboard : Form
{
    private readonly TicketService _ticketService;
    private readonly User user;

    public Dashboard(User user)
    {
        //Initializing lists, getting all tickets
        InitializeComponent();
        this.user = user;
        _ticketService = new TicketService();
        UpdateOpenTicketsProgressBar();
        UpdatePastDeadlineProgressBar();
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;

        this.lblBarNoDesk.Text = user.email;
        this.btnUserManagement.Enabled = this.user.userType == UserType.ServiceDeskUser || this.user.userType == UserType.Manager;
    }

    //Getting all tickets with status open and setting the progress bar and label with the correct data
    private void UpdateOpenTicketsProgressBar()
    {
        List<Ticket> allTickets = _ticketService.GetAllTickets();
        List<Ticket> openTickets = _ticketService.GetOpenTicketsUsingAggregation();

        pbOpen.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
        pbOpen.Value = openTickets.Count;
        lblOpenTicketCount.Text = $"Open Tickets: {openTickets.Count}";
    }

    //Getting all tickets that are past deadline and setting the progress bar and label with the correct data
    private void UpdatePastDeadlineProgressBar()
    {
        List<Ticket> pastDeadlineTickets = _ticketService.GetTicketsPastDeadlineUsingAggregation();
        List<Ticket> allTickets = _ticketService.GetAllTickets();

        pbDeadline.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
        pbDeadline.Value = pastDeadlineTickets.Count;
        lblPastDeadlineCount.Text = $"Past Deadline Tickets: {pastDeadlineTickets.Count}";
    }

    //Opens the additional part, which displays the list of tickets that are overdue
    private void btnListViewDeadline_Click(object sender, EventArgs e)
    {
        ListViewForDeadlineTickets listView = new ListViewForDeadlineTickets(this.user);
        Hide();
        listView.Show();
        listView.FormClosed += (s, args) => Close();
    }

    //Opens the additional part, which displays the list of tickets that have unresolved tickets 
    private void btnListViewUnresolved_Click(object sender, EventArgs e)
    {
        ListViewForOpenTickets listView = new ListViewForOpenTickets(this.user);
        Hide();
        listView.Show();
        listView.FormClosed += (s, args) => Close();
    }

    //Opens list view of all tickets
    private void showList_Click(object sender, EventArgs e)
    {
        TicketOverview ticketOverview = new TicketOverview(this.user);
        Hide();
        ticketOverview.Show();
        ticketOverview.FormClosed += (s, args) => Close();
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {

    }

    private void showList_Click_1(object sender, EventArgs e)
    {

    }

    private void lblBarNoDesk_Click(object sender, EventArgs e)
    {

    }

    private void btnUserManagement_Click(object sender, EventArgs e)
    {

    }
}