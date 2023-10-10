using Model;
using Service;
using Services;

namespace UI;

public partial class CreateTicket : Form
{
    private readonly TicketService _ticketService;
    private readonly UserService _userService;

    public CreateTicket()
    {
        InitializeComponent();
        _ticketService = new TicketService();
        _userService = new UserService();
    }

    private void CreateTicket_Load(object sender, EventArgs e)
    {
        cBPriority.DataSource = Enum.GetValues(typeof(PriorityEnum));
        cBTypeIncident.DataSource = Enum.GetValues(typeof(TypeOfIncidentEnum));
    }


    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void btnSubmitTicket_Click(object sender, EventArgs e)
    {
    }

    private void lblBarNoDesk_Click(object sender, EventArgs e)
    {
    }
}