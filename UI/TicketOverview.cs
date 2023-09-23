namespace UI;

public partial class TicketOverview : Form
{
    public TicketOverview()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard();
        dashboard.Show();
        Close();
    }
}