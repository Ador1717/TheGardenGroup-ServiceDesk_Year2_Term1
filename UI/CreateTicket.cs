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
        _ticketService = new TicketService();
        _userService = new UserService();
        this.user = user;
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


    private void btnUserManagement_Click(object sender, EventArgs e)
    {
    }

    private void cBTypeIncident_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void CreateTicket_Load(object sender, EventArgs e)
    {
        cBPriority.DataSource = Enum.GetValues(typeof(PriorityEnum));
        cBTypeIncident.DataSource = Enum.GetValues(typeof(TypeOfIncidentEnum));
    }


    private void lblBarNoDesk_Click(object sender, EventArgs e)
    {
    }
}