﻿using Model;
using Service;

namespace UI;

public partial class ListViewForDeadlineTickets : Form
{
    private readonly TicketService _ticketService;
    private readonly User _user;

    public ListViewForDeadlineTickets(User user)
    {
        try
        {
            // Loads ticket information and loads them into the list view
            InitializeComponent();
            _ticketService = new TicketService();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ConfigureListView();
            LoadTickets();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred during initialization: " + ex.Message);
        }
    }

    // Loads tickets that are overdue 
    private void LoadTickets()
    {
        try
        {
            IEnumerable<Ticket> deadlineTickets = _ticketService.GetTicketsPastDeadlineUsingAggregation();
            PopulateListView(deadlineTickets);
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while loading overdue tickets: " + ex.Message);
        }
    }

    // Populates list view with the list of tickets
    private void PopulateListView(IEnumerable<Ticket> tickets)
    {
        try
        {
            listViewTickets.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.ticketId.ToString())
                {
                    SubItems =
                    {
                        ticket.reportedByUser,
                        ticket.dateTimeReported.ToString("yyyy-MM-dd HH:mm:ss"),
                        ticket.status.ToString(),
                        ticket.priorityEnum.ToString(),
                        ticket.typeOfIncidentEnum.ToString()
                    }
                };
                listViewTickets.Items.Add(item);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while populating the list view: " + ex.Message);
        }
    }

    // Configures the list view with the correct formatting
    private void ConfigureListView()
    {
        try
        {
            listViewTickets.GridLines = true;
            listViewTickets.FullRowSelect = true;
            listViewTickets.View = View.Details;

            listViewTickets.Columns.AddRange(new[]
            {
                new ColumnHeader { Text = @"Id", Width = 100 },
                new ColumnHeader { Text = @"Name", Width = 120 },
                new ColumnHeader { Text = @"Date & Time Reported", Width = 160 },
                new ColumnHeader { Text = @"Status", Width = 90 },
                new ColumnHeader { Text = @"Priority", Width = 150 }
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while configuring the list view: " + ex.Message);
        }
    }

    // Goes back to the dashboard
    private void btnGoBack_Click(object sender, EventArgs e)
    {
        try
        {
            Dashboard dashboard = new Dashboard(_user);
            Hide();
            dashboard.Show();
            dashboard.FormClosed += (s, args) => Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(@"An error occurred while returning to the dashboard: " + ex.Message);
        }
    }
}