using MongoDB.Driver;

namespace QTS_ERP_Systems
{
    class DbCon
    {
        private IMongoDatabase db;
        readonly string DbName = "QTS_ERP";

        public DbCon()
        {
            var client = new MongoClient();
            db = client.GetDatabase(DbName);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var Collection = db.GetCollection<T>(table);
            Collection.InsertOne(record);
        }
    }
}
