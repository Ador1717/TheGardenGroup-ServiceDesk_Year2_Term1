using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL;

public class TicketDAO : MongoDBConnection
{
    protected static IMongoCollection<BsonDocument> ticketCollection;

    public TicketDAO()
    {
        ticketCollection = database.GetCollection<BsonDocument>("Tickets");
    }
}