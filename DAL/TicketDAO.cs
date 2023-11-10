using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL;

public class TicketDAO
{
    private readonly IMongoCollection<Ticket> ticketCollection;

    public TicketDAO()
    {
        ticketCollection = MongoDBConnection.Instance.Database.GetCollection<Ticket>("Tickets");
    protected static IMongoCollection<Ticket> ticketCollection;
    protected static IMongoCollection<User> userCollection;

    public TicketDAO()
    {
        ticketCollection = database.GetCollection<Ticket>("Tickets");
        userCollection = database.GetCollection<User>("Users");
    }


    public IEnumerable<Ticket> GetTicketsByReporterEmail(string email)
    {
        return ticketCollection.Find(ticket => ticket.reportedByUser == email).ToList();
    }

    public List<Ticket> GetAllTickets()
    {
        // Define the aggregation pipeline to match tickets with user details.
        var aggregation = ticketCollection.Aggregate()
            .Lookup(
                foreignCollectionName: "Users",
                localField: "userId",
                foreignField: "_id",
                @as: "userDetails"
            )
            .Unwind("userDetails", new AggregateUnwindOptions<Ticket> { PreserveNullAndEmptyArrays = true })
            .As<Ticket>()
            .ToList();

        return aggregation;
       

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
        FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(t => t.ticketId, ticketId);
        DeleteResult result = ticketCollection.DeleteOne(filter);
        return result.DeletedCount > 0;
    }

    public bool UpdateTicketStatus(ObjectId ticketId, TicketStatus newStatus)
    {
        FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(t => t.ticketId, ticketId);
        UpdateDefinition<Ticket> update = Builders<Ticket>.Update.Set(t => t.status, newStatus);
        UpdateResult result = ticketCollection.UpdateOne(filter, update);
        return result.ModifiedCount > 0;
    }

    //The following query is finding tickets by status by using the match aggregation function
    public List<Ticket> GetOpenTicketsUsingAggregation()
    {
        try
        {
            BsonDocument[] pipeline =
            {
                new BsonDocument("$match",
                    new BsonDocument("status",
                        new BsonDocument("$eq", "Open")))
            };

            return ticketCollection.Aggregate<Ticket>(pipeline).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return new List<Ticket>();
        }
    }

    //The following query is finding tickets that have ticket status open and that its deadline is over today's date.
    public List<Ticket> GetTicketsPastDeadlineUsingAggregation()
    {
        try
        {
            DateTime currentDateTime = DateTime.UtcNow.Date;
            BsonDateTime bsonCurrentDateTime = new BsonDateTime(currentDateTime);
            BsonDocument[] pipeline =
            {
                new BsonDocument("$addFields",
                    new BsonDocument("deadline",
                        new BsonDocument("$dateFromParts",
                            new BsonDocument
                            {
                                { "year", new BsonDocument("$year", new BsonDocument("$toDate", "$deadline")) },
                                { "month", new BsonDocument("$month", new BsonDocument("$toDate", "$deadline")) },
                                { "day", new BsonDocument("$dayOfMonth", new BsonDocument("$toDate", "$deadline")) }
                            }
                        )
                    )
                ),
                new BsonDocument("$match",
                    new BsonDocument("$expr",
                        new BsonDocument("$and",
                            new BsonArray
                            {
                                new BsonDocument("$lt",
                                    new BsonArray
                                    {
                                        "$deadline",
                                        bsonCurrentDateTime
                                    }),
                                new BsonDocument("$eq",
                                    new BsonArray
                                    {
                                        "$status",
                                        "Open"
                                    })
                            })))
            };
            return ticketCollection.Aggregate<Ticket>(pipeline).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return new List<Ticket>();
        }
    }
}