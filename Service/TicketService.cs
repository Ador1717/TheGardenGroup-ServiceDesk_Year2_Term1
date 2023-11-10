using DAL;
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

    public List<Ticket> GetOpenTicketsUsingAggregation()
    {
        return _ticketDAO.GetOpenTicketsUsingAggregation();
    }

    public List<Ticket> GetTicketsPastDeadlineUsingAggregation()
    {
        return _ticketDAO.GetTicketsPastDeadlineUsingAggregation();
    }
}