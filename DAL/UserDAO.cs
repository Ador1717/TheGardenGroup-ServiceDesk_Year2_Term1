using Model;
using MongoDB.Driver;

namespace DAL;

public class UserDAO
{
    public UserDAO()
    {
        MongoDBConnection dbConnection = new MongoDBConnection();
    }

    public User GetByUsername(string username)
    {
        IMongoCollection<User>? collection = MongoDBConnection.database.GetCollection<User>("Users");

        FilterDefinition<User>? filter = Builders<User>.Filter.Eq(u => u.firstName, username);
        User user = collection.Find(filter).FirstOrDefault();
        return user;
    }
}