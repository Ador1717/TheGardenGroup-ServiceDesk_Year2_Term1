using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model;

public class Ticket
{
    public Ticket(ObjectId ticketId, DateTime dateTimeReported, string subject, TypeOfIncidentEnum typeOfIncidentEnum,
        string reportedByUser, PriorityEnum priorityEnum, DateTime deadline, string description, TicketStatus status)
    {
        this.ticketId = ticketId;
        this.dateTimeReported = dateTimeReported;
        this.subject = subject;
        this.typeOfIncidentEnum = typeOfIncidentEnum;
        this.reportedByUser = reportedByUser;
        this.priorityEnum = priorityEnum;
        this.deadline = deadline;
        this.description = description;
        this.status = status;
    }

    [BsonId] public ObjectId ticketId { get; set; }
    [BsonElement("dateTimeReported")] public DateTime dateTimeReported { get; set; }
    [BsonElement("subject")] public string subject { get; set; }
    [BsonElement("typeOfIncident")] public TypeOfIncidentEnum typeOfIncidentEnum { get; set; }
    [BsonElement("reportedByUser")] public string reportedByUser { get; set; }
    [BsonElement("priority")] public PriorityEnum priorityEnum { get; set; }
    [BsonElement("deadline")] public DateTime deadline { get; set; }
    [BsonElement("description")] public string description { get; set; }
    [BsonElement("status")] public TicketStatus status { get; set; }
}