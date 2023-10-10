﻿using DAL;
using Model;
using MongoDB.Bson;

namespace Service;

public class TicketService
{
    private readonly TicketDAO _ticketDAO;

    public TicketService()
    {
        _ticketDAO = new TicketDAO();
    }
    public IEnumerable<Ticket> GetTicketsByReporterEmail(string email)
    {
        // additional business logic if needed
        return _ticketDAO.GetTicketsByReporterEmail(email);
    }
    public List<Ticket> GetAllTickets()
    {
        return _ticketDAO.GetAllTickets();
    }

    public List<Ticket> GetTicketsByStatus(TicketStatus status)
    {
        return _ticketDAO.GetTicketsByStatus(status);
    }

    public List<Ticket> GetTicketsByDate(DateTime date)
    {
        return _ticketDAO.GetTicketsByDate(date);
    }

    public bool AddTicket(DateTime dateTimeReported, string subject,
        TypeOfIncidentEnum typeOfIncidentEnum,
        string reportedByUser, PriorityEnum priorityEnum, DateTime deadline, string description)
    {
        Ticket newTicket = new Ticket( dateTimeReported, subject, typeOfIncidentEnum, reportedByUser,
            priorityEnum, deadline, description);
        return _ticketDAO.AddTicket(newTicket);
    }

    public bool DeleteTicket(ObjectId ticketId)
    {
        return _ticketDAO.DeleteTicket(ticketId);
    }

    public bool UpdateTicketStatus(ObjectId ticketId, TicketStatus newStatus)
    {
        return _ticketDAO.UpdateTicketStatus(ticketId, newStatus);
    }

    public List<Ticket> GetTicketsPastDeadline()
    {
        return _ticketDAO.GetTicketsPastDeadline();
    }
}