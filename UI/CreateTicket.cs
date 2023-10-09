using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;
using Services;

namespace UI
{
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
            cBPriority.DataSource = Enum.GetValues(typeof(Model.PriorityEnum));
            cBTypeIncident.DataSource = Enum.GetValues(typeof(Model.TypeOfIncidentEnum));
        }

     



        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.dateTimeReported = dTPReportedDate.Value;
            ticket.subject = tBSusbject.Text;
            ticket.typeOfIncidentEnum= (TypeOfIncidentEnum)cBTypeIncident.SelectedItem;
            ticket.reportedByUser = cBUser.ValueMember;
            ticket.priorityEnum = (PriorityEnum)cBPriority.SelectedItem;
            ticket.deadline= dTPDeadline.Value;
            ticket.description= tBDescription.Text;

            _ticketService.AddTicket(ticket);

        }

        private void lblBarNoDesk_Click(object sender, EventArgs e)
        {
        }
    }
}
