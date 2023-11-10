using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL;

public class UserDAO
{
    private readonly IMongoCollection<User> userCollection;

    public UserDAO()
    {
        userCollection = MongoDBConnection.Instance.Database.GetCollection<User>("Users");
    }

    public User GetUserByEmail(string email)
    {
        return userCollection.Find(user => user.email == email).FirstOrDefault();
    }

    public User GetByUsername(string username)
    {
        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.username, username);
        return userCollection.Find(filter).FirstOrDefault();
    }

    public List<User> GetAllUsers()
    {
        return userCollection.Find(new BsonDocument()).ToList();
    }


    public BsonDocument AddUser(string email, string userName, string name, string password,
        UserType userType, string phoneNumber, string location)
    {
        BsonDocument document = new BsonDocument
        {
            { "email", email },
            { "name", name },
            { "userType", userType.ToString() },
            { "phone", phoneNumber },
            { "location", location }
        };
        return document;
    }

    public bool UserExists(string email)
    {
        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.email, email);
        User? user = userCollection.Find(filter).FirstOrDefault();
        return user != null;
    }

    public bool HashedPassword(string email, string hashedPassword)
    {
        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.email, email);
        UpdateDefinition<User>? update = Builders<User>.Update.Set(u => u.hashedPassword, hashedPassword);
        UpdateResult? result = userCollection.UpdateOne(filter, update);
        return result.MatchedCount > 0;
    }
}