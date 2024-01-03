using Microsoft.VisualBasic.ApplicationServices;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EditTicket : Form
    {
        private Ticket _ticketToEdit;
        private readonly TicketService _ticketService;
        public EditTicket(Ticket ticketToEdit)
        {
            InitializeComponent();
            _ticketToEdit = ticketToEdit;
            PopulateComboBoxes();
            _ticketService = new TicketService();

        }
        private void PopulateComboBoxes()
        {
            cBPriority.Items.Clear();
            cBTypeIncident.Items.Clear();
            cBStuts.Items.Clear();

            foreach (var stuts in Enum.GetValues(typeof(TicketStatus)))
            {
                cBStuts.Items.Add(stuts.ToString());
            }

            foreach (var priority in Enum.GetValues(typeof(PriorityEnum)))
            {
                cBPriority.Items.Add(priority.ToString());
            }

            foreach (var typeOfIncident in Enum.GetValues(typeof(TypeOfIncidentEnum)))
            {
                cBTypeIncident.Items.Add(typeOfIncident.ToString());
            }

            cBStuts.SelectedItem = _ticketToEdit.status.ToString();
            cBPriority.SelectedItem = _ticketToEdit.priorityEnum.ToString();
            cBTypeIncident.SelectedItem = _ticketToEdit.typeOfIncidentEnum.ToString();
        }

        private void EditTicket_Load(object sender, EventArgs e)
        {
            dTPReportedDate.Value = _ticketToEdit.dateTimeReported;
            dTPDeadline.Value = _ticketToEdit.deadline;
            tBSubject.Text = _ticketToEdit.subject;
            tBDescription.Text = _ticketToEdit.description;
            cBUser.Text = _ticketToEdit.reportedByUser;

            // Here you should also populate your ComboBoxes with the enum values
            // This assumes your ComboBoxes have the enum values already added
            cBPriority.SelectedItem = _ticketToEdit.priorityEnum.ToString();
            cBTypeIncident.SelectedItem = _ticketToEdit.typeOfIncidentEnum.ToString();

        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            // Validate ComboBox selections
            if (cBPriority.SelectedItem == null || cBTypeIncident.SelectedItem == null)
            {
                MessageBox.Show("Please select both a priority and a type of incident.");
                return;
            }

            _ticketToEdit.dateTimeReported = dTPReportedDate.Value;
            _ticketToEdit.deadline = dTPDeadline.Value;
            _ticketToEdit.subject = tBSubject.Text;
            _ticketToEdit.description = tBDescription.Text;
            _ticketToEdit.reportedByUser = cBUser.Text;

            _ticketToEdit.priorityEnum = (PriorityEnum)Enum.Parse(typeof(PriorityEnum), cBPriority.SelectedItem.ToString());
            _ticketToEdit.typeOfIncidentEnum = (TypeOfIncidentEnum)Enum.Parse(typeof(TypeOfIncidentEnum), cBTypeIncident.SelectedItem.ToString());
            _ticketToEdit.status = (TicketStatus)Enum.Parse(typeof(TicketStatus), cBStuts.SelectedItem.ToString());

            _ticketService.UpdateTicket(_ticketToEdit);

            MessageBox.Show("Ticket updated successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}

