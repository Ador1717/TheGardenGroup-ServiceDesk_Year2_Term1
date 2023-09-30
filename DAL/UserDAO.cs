using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DAL;

public class UserDAO : MongoDBConnection
{
    public static IMongoCollection<BsonDocument> userCollection;

    public UserDAO()
    {
        userCollection = database.GetCollection<BsonDocument>("Users");
    }

    public User GetByUsername(string username)
    {
        IMongoCollection<User>? collection = database.GetCollection<User>("Users");

        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.firstName, username);
        User user = collection.Find(filter).FirstOrDefault();
        return user;
    }

    public List<User> GetAllUsers()
    {
        List<User> allUsers = new List<User>();
        List<BsonDocument>? documents = userCollection.Find(new BsonDocument()).ToList();

        foreach (BsonDocument document in documents)
        {
            User user = BsonSerializer.Deserialize<User>(document);
            allUsers.Add(user);
        }

        return allUsers;
    }

    public BsonDocument AddUser(string email, string userName, BsonDocument name, BsonDocument password,
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