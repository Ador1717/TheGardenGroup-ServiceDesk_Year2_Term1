using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model;

public class User
{
   
    public User(ObjectId userId, string firstName, string lastName, UserType userType, string email,
        string phoneNumber, string location, string salt, string hashedPassword, string username, List<string> reportedTickets)
    {
        this.userId = userId;
        this.username = username;
        this.firstName = firstName;
        this.lastName = lastName;
        this.userType = userType;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.location = location;
        this.salt = salt;
        this.hashedPassword = hashedPassword;
    }

    [BsonId] public ObjectId userId { get; set; }

    [BsonElement("ID")] public string ID { get; set; }
    [BsonElement("username")] public string username { get; set; }
    [BsonElement("firstName")] public string firstName { get; set; }
    [BsonElement("lastName")] public string lastName { get; set; }
    [BsonElement("userType")] public UserType userType { get; set; }
    [BsonElement("email")] public string email { get; set; }
    [BsonElement("phone")] public string phoneNumber { get; set; }
    [BsonElement("location")] public string location { get; set; }
    [BsonElement("salt")] public string salt { get; set; }
    [BsonElement("hashedPassword")] public string hashedPassword { get; set; }
}