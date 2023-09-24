using MongoDB.Driver;

namespace DAL;

public class MongoDBConnection
{
    protected static IMongoDatabase database;

    public MongoDBConnection()
    {
        MongoClient client =
            new MongoClient(
                "mongodb+srv://Ted:*049810Tc*@gardengroupproject.rsow8xd.mongodb.net/?retryWrites=true&w=majority");
        database = client.GetDatabase("GardenGroupProject");
    }
}