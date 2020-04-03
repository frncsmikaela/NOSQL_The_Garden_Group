using System;
using MongoDB.Driver;

namespace ServiceDeskDAL
{
    public class Base
    {
        protected IMongoDatabase dbServDesk;
        public Base()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://admin:admin@cluster0-6vgii.mongodb.net/test?retryWrites=true&w=majority");
            this.dbServDesk = dbClient.GetDatabase("servicedesk");
        }
      
    }
}

