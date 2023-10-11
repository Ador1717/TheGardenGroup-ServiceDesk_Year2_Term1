using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL;

public class TicketDAO : MongoDBConnection
{
    protected static IMongoCollection<Ticket> ticketCollection;

    public TicketDAO()
    {
        ticketCollection = database.GetCollection<Ticket>("Tickets");
    }

    public IEnumerable<Ticket> GetTicketsByReporterEmail(string email)
    {
        return ticketCollection.Find(ticket => ticket.reportedByUser == email).ToList();
    }

    public List<Ticket> GetAllTickets()
    {
        return ticketCollection.Find(new BsonDocument()).ToList();
    }

    public List<Ticket> GetTicketsByStatus(TicketStatus status)
    {
        FilterDefinition<Ticket>? filter = Builders<Ticket>.Filter.Eq(t => t.status, status);
        return ticketCollection.Find(filter).ToList();
    }

    public List<Ticket> GetTicketsByDate(DateTime date)
    {
        FilterDefinition<Ticket>? filter = Builders<Ticket>.Filter.Eq(t => t.dateTimeReported, date);
        return ticketCollection.Find(filter).ToList();
    }

    public bool AddTicket(Ticket ticket)
    {
        try
        {
            ticketCollection.InsertOne(ticket);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool DeleteTicket(ObjectId ticketId)
    {
        FilterDefinition<Ticket>? filter = Builders<Ticket>.Filter.Eq(t => t.ticketId, ticketId);
        DeleteResult? result = ticketCollection.DeleteOne(filter);
        return result.DeletedCount > 0;
    }

    public bool UpdateTicketStatus(ObjectId ticketId, TicketStatus newStatus)
    {
        FilterDefinition<Ticket>? filter = Builders<Ticket>.Filter.Eq(t => t.ticketId, ticketId);
        UpdateDefinition<Ticket>? update = Builders<Ticket>.Update.Set(t => t.status, newStatus);
        UpdateResult? result = ticketCollection.UpdateOne(filter, update);
        return result.ModifiedCount > 0;
    }

    public List<Ticket> GetTicketsPastDeadline()
    {
        FilterDefinition<Ticket>? filter = Builders<Ticket>.Filter.Lt(t => t.deadline, DateTime.Now);
        return ticketCollection.Find(filter).ToList();
    }
}