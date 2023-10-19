﻿using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL;

public class TicketDAO
{
    private readonly IMongoCollection<Ticket> ticketCollection;

    public TicketDAO()
    {
        ticketCollection = MongoDBConnection.Instance.Database.GetCollection<Ticket>("Tickets");
    }


    public IEnumerable<Ticket> GetTicketsByReporterEmail(string email)
    {
        return ticketCollection.Find(ticket => ticket.reportedByUser == email).ToList();
    }

    public List<Ticket> GetAllTickets()
    {
        return ticketCollection.Find(new BsonDocument()).ToList();
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


    public List<Ticket> GetOpenTicketsUsingAggregation()
    {
        BsonDocument[] pipeline =
        {
            new BsonDocument("$match",
                new BsonDocument("status",
                    new BsonDocument("$eq", "Open")))
        };

        return ticketCollection.Aggregate<Ticket>(pipeline).ToList();
    }

    public List<Ticket> GetTicketsPastDeadlineUsingAggregation()
    {
        BsonDocument[] pipeline =
        {
            new BsonDocument("$match",
                new BsonDocument("$expr",
                    new BsonDocument("$and",
                        new BsonArray
                        {
                            new BsonDocument("$lt",
                                new BsonArray
                                {
                                    "$deadline",
                                    new BsonDocument("$toDate", "$$NOW")
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
}