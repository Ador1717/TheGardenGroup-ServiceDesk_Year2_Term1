using Model;
using Service;
using Services;

namespace UI;

public partial class CreateTicket : Form
{
    private readonly TicketService _ticketService;
    private readonly UserService _userService;
    private readonly User user;

    public CreateTicket(User user)
    {
        InitializeComponent();
        cBPriority.DataSource = Enum.GetValues(typeof(PriorityEnum));
        cBTypeIncident.DataSource = Enum.GetValues(typeof(TypeOfIncidentEnum));
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        _ticketService = new TicketService();
        _userService = new UserService();
        this.user = user;
        label8.Text = user.email;
    }


    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void btnSubmitTicket_Click(object sender, EventArgs e)
    {
        Ticket ticket = new Ticket
        {
            dateTimeReported = dTPReportedDate.Value,
            subject = tBSubject.Text,
            typeOfIncidentEnum = (TypeOfIncidentEnum)cBTypeIncident.SelectedItem,
            reportedByUser = cBUser.Text,
            priorityEnum = (PriorityEnum)cBPriority.SelectedItem,
            deadline = dTPDeadline.Value,
            description = tBDescription.Text,
            status = TicketStatus.Open,
            userId = user.userId
        };
        _ticketService.AddTicket(ticket);
        MessageBox.Show("Ticket submitted successfully!", "Confirmation", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        ResetFields();
    }

    private void ResetFields()
    {
        dTPReportedDate.Value = DateTime.Now;
        tBSubject.Clear();
        //cBTypeIncident.Clear(); // Assuming default is no selection.
        cBUser.Clear(); // Assuming default is no selection.
        //cBPriority.Clear(); // Assuming default is no selection.
        dTPDeadline.Value = DateTime.Now;
        tBDescription.Clear();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        ResetFields();
        Close();
    }


    private void btnMenuDashboard_Click(object sender, EventArgs e)
    {
        Dashboard dashboard = new Dashboard(user);
        dashboard.Show();
        Hide();
        dashboard.FormClosed += (s, args) => Close();
    }

    private void btnMenuIncidentManagement_Click(object sender, EventArgs e)
    {
        TicketOverview ticketOverview = new TicketOverview(user);
        ticketOverview.Show();
        Hide();
        ticketOverview.FormClosed += (s, args) => Close();
    }

    private void btnUserManagement_Click_1(object sender, EventArgs e)
    {
        UserManagement userManagementForm = new UserManagement(user);
        userManagementForm.Show();
        Hide();
        userManagementForm.FormClosed += (s, args) => Close();
    }
}