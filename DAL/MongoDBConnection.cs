using MongoDB.Driver;

namespace DAL
{
    public class MongoDBConnection
    {
        public static IMongoDatabase database;

        public MongoDBConnection()
        {
            MongoClient client =
                new MongoClient(
                    "mongodb+srv://Ted:*049810Tc*@gardengroupproject.rsow8xd.mongodb.net/");

            database = client.GetDatabase("GardenGroup");
        }

    }
}
