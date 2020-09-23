using MongoDB.Driver;

namespace QTS_ERP_Systems
{
    class DbCon
    {
        private IMongoDatabase db;

        public DbCon(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var Collection = db.GetCollection<T>(table);
            Collection.InsertOne(record);
        }
    }
}
