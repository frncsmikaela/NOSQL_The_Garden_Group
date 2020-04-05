using System;
using System.Collections.Generic;
using System.Text;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
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

        public bool Exists(int phone)
        {
            var result = collection.Find(i => i.phone == phone);
            int count = (int)result.CountDocuments();

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UpdateUser(User u)
        {
            var filter = Builders<User>.Filter.Eq("phone", u.phone);
            var newValue = Builders<User>.Update.Set("firstName", u.firstName).Set("lastName", u.lastName).Set("type", u.type)
                .Set("email", u.email).Set("location", u.location);
            collection.UpdateOne(filter, newValue);
        }

        public void InsertUser(User u)
        {
            collection.InsertOne(u);
        }

        public void DeleteUser(ObjectId id)
        {
            var deleteFilter = Builders<User>.Filter.Eq("_id", id);
            collection.DeleteOne(deleteFilter);
        }
    }
}
