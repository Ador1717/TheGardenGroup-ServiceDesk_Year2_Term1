﻿using Model;
using Service;

namespace UI;

public partial class ListViewForOpenTickets : Form
{
    private readonly TicketService _ticketService;

    public ListViewForOpenTickets()
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
        IEnumerable<Ticket> openTickets = _ticketService.GetOpenTickets();
        PopulateListView(openTickets);
    }

    private void PopulateListView(IEnumerable<Ticket> tickets)
    {
        listViewTickets.Items.Clear();

        foreach (Ticket ticket in tickets)
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
        Dashboard dashboard = new Dashboard();
        Hide();
        dashboard.Show();
        dashboard.FormClosed += (s, args) => Close();
    }
}