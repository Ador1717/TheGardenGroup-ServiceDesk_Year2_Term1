﻿using DAL;
using Model;
using MongoDB.Bson;

namespace Service;

public class TicketService
{
    private readonly TicketDAO _ticketDAO;
    private List<Ticket> incidentList;

    public TicketService()
    {
        _ticketDAO = new TicketDAO();
    }

    public IEnumerable<Ticket> GetTicketsByReporterEmail(string email)
    {
        return _ticketDAO.GetTicketsByReporterEmail(email);
    }

    public List<Ticket> GetAllTickets()
    {
        return _ticketDAO.GetAllTickets();
    }


    public void AddTicket(Ticket ticket)
    {
        _ticketDAO.AddTicket(ticket);
    }

    public bool DeleteTicket(ObjectId ticketId)
    {
        return _ticketDAO.DeleteTicket(ticketId);
    }

    public bool UpdateTicketStatus(ObjectId ticketId, TicketStatus newStatus)
    {
        return _ticketDAO.UpdateTicketStatus(ticketId, newStatus);
    }

    public List<Ticket> GetOpenTicketsUsingAggregation(string userName)
    {
        return _ticketDAO.GetOpenTicketsUsingAggregation(userName);
    }

    public List<Ticket> GetTicketsPastDeadlineUsingAggregation(string userName)
    {
        return _ticketDAO.GetTicketsPastDeadlineUsingAggregation(userName);
    }
    public Ticket GetTicketById(ObjectId ticketId)
    {
        return _ticketDAO.GetTicketById(ticketId);
    }
    public bool UpdateTicket(Ticket updatedTicket)
    {
        return _ticketDAO.UpdateTicket(updatedTicket);
    }

}