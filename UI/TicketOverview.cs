﻿using DAL;
using Model;
using Service;
using Services;

namespace UI;

public partial class TicketOverview : Form
{
    private readonly TicketService _ticketService;
    private readonly UserService _userService;

    public TicketOverview()
    {
        InitializeComponent();
        _ticketService = new TicketService();
        _userService = new UserService();
        LoadTicketData();
    }

    private void LoadTicketData()
    {
        listviewTicketOverview.Items.Clear();

        IEnumerable<Ticket> tickets = _ticketService.GetAllTickets();

        // Format and display data in ListView or other control.
        foreach (var ticket in tickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();

            item.SubItems.Add(ticket.email);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listviewTicketOverview.Items.Add(item);
        }
    }

    private void TicketOverview_Load(object sender, EventArgs e)
    {

        listviewTicketOverview.GridLines = true;
        listviewTicketOverview.FullRowSelect = true;
        listviewTicketOverview.View = System.Windows.Forms.View.Details;
        listviewTicketOverview.Columns.Add("_Id", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("SubjectEmail", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("username", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("dateTimeReported", 100, HorizontalAlignment.Left);
        listviewTicketOverview.Columns.Add("Status", 100, HorizontalAlignment.Left);

        LoadTicketData();
    }

    private void txtBoxFilterEmail_TextChanged(object sender, EventArgs e)
    {
        FilterTickets(txtBoxFilterEmail.Text);
    }
    private void FilterTickets(string emailFilter)
    {
        listviewTicketOverview.Items.Clear();

        IEnumerable<Ticket> tickets = _ticketService.GetAllTickets();

        // Filter the tickets based on the emailFilter.
        var filteredTickets = tickets.Where(t =>
            t.email != null &&
            t.email.Contains(emailFilter, StringComparison.OrdinalIgnoreCase));
        foreach (var ticket in filteredTickets)
        {
            ListViewItem item = new ListViewItem(ticket.ticketId.ToString());
            item.Tag = ticket.ticketId.ToString();

            item.SubItems.Add(ticket.email);
            item.SubItems.Add(ticket.reportedByUser);
            item.SubItems.Add(ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(ticket.status.ToString());
            listviewTicketOverview.Items.Add(item);
        }
    }

    private void btnCreateIncident_Click(object sender, EventArgs e)
    {
        CreateTicket create = new CreateTicket();
        create.ShowDialog();
        LoadTicketData();

    }
}
