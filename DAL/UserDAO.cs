using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DAL;

public class UserDAO : MongoDBConnection
{
    protected static IMongoCollection<User> userCollection;
    //protected static IMongoCollection<Ticket> ticketCollection;

    public UserDAO()
    {
        userCollection = database.GetCollection<User>("Users");   
    }
   
    public User GetUserByEmail(string email)
    {
        return userCollection.Find(user => user.email == email).FirstOrDefault(); ;
    }

   

    public User GetByUsername(string username)
    {
        IMongoCollection<User>? collection = database.GetCollection<User>("Users");

        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.firstName, username);
        User user = collection.Find(filter).FirstOrDefault();
        return user;
    }

   

    public BsonDocument AddUser(string email, string userName, string name, string password,
        UserType userType, string phoneNumber, string location)
    {
        BsonDocument document = new BsonDocument
        {
            { "Email", email },
            { "UserName", userName },
            { "Name", name },
            { "Password", password },
            { "UserType", userType },
            { "PhoneNumber", phoneNumber },
            { "Location", location }
        };
        return document;
    }

    public bool UserExists(string email)
    {
        IMongoCollection<BsonDocument>? collection = database.GetCollection<BsonDocument>("Users");

        FilterDefinition<BsonDocument>? filter = Builders<BsonDocument>.Filter.Eq("email", email);
        BsonDocument? user = collection.Find(filter).FirstOrDefault();

        return user != null;
    }

    public bool HashedPassword(string email, string hashedPassword)
    {
        IMongoCollection<User>? collection = database.GetCollection<User>("Users");

        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.email, email);
        UpdateDefinition<User>? update = Builders<User>.Update.Set(u => u.hashedPassword, hashedPassword);

        UpdateResult? result = collection.UpdateOne(filter, update);

        return result.MatchedCount > 0;
    }
}