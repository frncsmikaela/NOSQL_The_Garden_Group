using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace ServiceDeskDAL
{
    public class Languages_DAL
    {
        private IMongoCollection<Language> collection;

        public Languages_DAL()
        {
            MongoClient conn = Base.GetInstance();
            IMongoDatabase dbServDesk = conn.GetDatabase("servicedesk");
            collection = dbServDesk.GetCollection<Language>("languages");
        }

        public IFindFluent<Language, Language> AllLanguages()
        {
            var allLanguages = collection.Find(i => true);
            return allLanguages;
        }
    }
}
