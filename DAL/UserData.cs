using Model;
using MongoDB.Driver;

namespace DAL
{
    public class UserData
    {

        public UserData()
        {
            MongoDBConnection dbConnection = new MongoDBConnection();
        }

        public User GetByUsername(string username)
        {
            var collection = MongoDBConnection.database.GetCollection<User>("Users");

            var filter = Builders<User>.Filter.Eq(u => u.firstName, username);
            User user = collection.Find(filter).FirstOrDefault();
            return user;
        }

    }
}