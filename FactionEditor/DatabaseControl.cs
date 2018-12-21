using MongoCRUD;

namespace FactionEditor
{
    public static class DatabaseControl
    {
        public static Crud<Faction> CrudFaction;
        public static void StartDatabaseConnection()
        {
            const string ConnectionString = "mongodb://ohm:741895623ohm@test-shard-00-00-imtir.mongodb.net:27017,test-shard-00-01-imtir.mongodb.net:27017,test-shard-00-02-imtir.mongodb.net:27017/test?ssl=true&replicaSet=test-shard-0&authSource=admin&retryWrites=true";
            MongoDbConnection.InitializeAndStartConnection(ConnectionString, databaseName: "MilitaryTCG");
            CrudFaction = new Crud<Faction>();
        }
    }
}
