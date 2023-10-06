using Model;
using Service;

namespace UI;

public partial class DashboardFilteredSearch : Form
{
    private readonly TicketService _ticketService;

    public DashboardFilteredSearch()
    {
        InitializeComponent();
        _ticketService = new TicketService();
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard();
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string input = txtBoxInput.Text;

            if (Enum.TryParse(input, true, out TicketStatus status))
            {
                List<Ticket> tickets = _ticketService.GetTicketsByStatus(status);
                dataGridFiltered.DataSource = tickets;
            }
            else
            {
                MessageBox.Show($"Invalid Status: {input}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}