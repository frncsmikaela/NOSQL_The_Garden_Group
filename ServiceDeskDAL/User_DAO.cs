using System;
using System.Collections.Generic;
using System.Text;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace ServiceDeskDAL
{
    public class User_DAO
    {
        private IMongoCollection<User> collection;

        public User_DAO()
        {
            MongoClient conn = Base.GetInstance();
            IMongoDatabase dbServDesk = conn.GetDatabase("servicedesk");
            collection = dbServDesk.GetCollection<User>("users");
        }

        public IFindFluent<User, User> retrieveUsers()
        {
            var allUsers = collection.Find(i => true);
            return allUsers;
        }
    }
}
