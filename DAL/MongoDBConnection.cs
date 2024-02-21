using MongoDB.Driver;

namespace DAL;

public class MongoDBConnection
{
    //Making Singelton pattern
    private static readonly Lazy<MongoDBConnection> instance =
        new Lazy<MongoDBConnection>(() => new MongoDBConnection());


    private MongoDBConnection()
    {
        MongoClient client = new MongoClient("mongodb+srv://Ted:*049810Tc*@gardengroupproject.rsow8xd.mongodb.net/");
        Database = client.GetDatabase("GardenGroup");
    }

    public IMongoDatabase Database { get; }

    public static MongoDBConnection Instance => instance.Value;
}