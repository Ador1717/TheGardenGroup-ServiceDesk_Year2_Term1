using Model;
using Service;

namespace UI;

public partial class Dashboard : Form
{
    private readonly TicketService _ticketService;
    private readonly User _user;

    public Dashboard(User user)
    {
        try
        {
            InitializeComponent();
            _user = user;
            _ticketService = new TicketService();
            UpdateOpenTicketsProgressBar();
            UpdatePastDeadlineProgressBar();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            lblBarNoDesk.Text = user.email;
            btnUserManagement.Enabled =
                _user.userType is UserType.ServiceDeskUser or UserType.Manager;
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred during initialization: " + ex.Message);
        }
    }

    //Loads a list of open tickets 
    private void UpdateOpenTicketsProgressBar()
    {
        try
        {
            List<Ticket> allTickets = _ticketService.GetAllTickets();
            List<Ticket> openTickets = _ticketService.GetOpenTicketsUsingAggregation();

            pbOpen.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
            pbOpen.Value = openTickets.Count;
            lblOpenTicketCount.Text = $@"Open Tickets: {openTickets.Count}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while updating open tickets: " + ex.Message);
        }
    }

    //Loads a list of unresolved tickets
    private void UpdatePastDeadlineProgressBar()
    {
        try
        {
            List<Ticket> pastDeadlineTickets = _ticketService.GetTicketsPastDeadlineUsingAggregation();
            List<Ticket> allTickets = _ticketService.GetAllTickets();

            pbDeadline.Maximum = allTickets.Count > 0 ? allTickets.Count : 1;
            pbDeadline.Value = pastDeadlineTickets.Count;
            lblPastDeadlineCount.Text = $@"Past Deadline Tickets: {pastDeadlineTickets.Count}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while updating past deadline tickets: " + ex.Message);
        }
    }


    private void showList_Click_1(object sender, EventArgs e)
    {
        try
        {
            TicketOverview ticketOverview = new TicketOverview(_user);
            Hide();
            ticketOverview.Show();
            ticketOverview.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while opening ticket overview: " + ex.Message);
        }
    }


    //Opens Joan's additional part that shows a list view of tickets which have status open
    private void btnListViewUnresolved_Click_1(object sender, EventArgs e)
    {
        try
        {
            ListViewForOpenTickets listView = new ListViewForOpenTickets(_user);
            Hide();
            listView.Show();
            listView.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while opening list view for open tickets: " + ex.Message);
        }
    }

    //Opens Joan's additional part that shows a list view of tickets which are overdue
    private void btnListViewDeadline_Click_1(object sender, EventArgs e)
    {
        try
        {
            ListViewForDeadlineTickets listView = new ListViewForDeadlineTickets(_user);
            Hide();
            listView.Show();
            listView.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while opening list view for deadline tickets: " + ex.Message);
        }
    }

    private void btnMenuIncidentManagement_Click(object sender, EventArgs e)
    {
        try
        {
            TicketOverview ticketOverview = new TicketOverview(_user);
            Hide();
            ticketOverview.Show();
            ticketOverview.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while opening ticket overview: " + ex.Message);
        }
    }

    private void btnUserManagement_Click(object sender, EventArgs e)
    {
        try
        {
            UserManagement userManagement = new UserManagement(_user);
            Hide();
            userManagement.Show();
            userManagement.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while opening ticket overview: " + ex.Message);
        }
    }
}