using Model;
using Service;

namespace UI;

public partial class ListViewForDeadlineTickets : Form
{
    private readonly TicketService _ticketService;

    public ListViewForDeadlineTickets()
    {
        InitializeComponent();
        _ticketService = new TicketService();
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        ConfigureListView();
        LoadTickets();
    }

    private void LoadTickets()
    {
        IEnumerable<Ticket> deadlineTickets = _ticketService.GetTicketsPastDeadline();

        listViewTickets.Items.Clear();

        foreach (Ticket ticket in deadlineTickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString())
            {
                Tag = ticket.ticketId.ToString(),
                SubItems =
                {
                    ticket.email,
                    ticket.reportedByUser,
                    ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"),
                    ticket.status.ToString()
                }
            };
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
        Dashboard dashboard = new Dashboard();
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }
}