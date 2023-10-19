using Model;
using Service;

namespace UI;

public partial class ListViewForOpenTickets : Form
{
    private readonly TicketService _ticketService;
    private readonly User user;

    public ListViewForOpenTickets(User user)
    {
        InitializeComponent();
        _ticketService = new TicketService();
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        this.user = user;
        ConfigureListView();
        LoadTickets();
    }

    private void LoadTickets()
    {
        // Use the GetTicketsByStatus method to retrieve open tickets
        IEnumerable<Ticket> openTickets = _ticketService.GetOpenTickets();

        listViewTickets.Items.Clear();

        foreach (Ticket ticket in openTickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();
            item.SubItems.Add(ticket.email);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listViewTickets.Items.Add(item);
        }
    }


    private void ConfigureListView()
    {
        listViewTickets.GridLines = true;
        listViewTickets.FullRowSelect = true;
        listViewTickets.View = View.Details;

        listViewTickets.Columns.AddRange(new[]
        {
            new ColumnHeader { Text = "Id", Width = 100 },
            new ColumnHeader { Text = "Email", Width = 200 },
            new ColumnHeader { Text = "Name", Width = 100 },
            new ColumnHeader { Text = "Date & Time Reported", Width = 200 },
            new ColumnHeader { Text = "Status", Width = 100 }
        });
    }

    private void btnGoBack_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard(this.user);
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }
}