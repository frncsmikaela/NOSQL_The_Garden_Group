using System;
using System.Collections.Generic;
using System.Text;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace ServiceDeskDAL
{
    public class Incident_DAO : Base
    {
        IMongoCollection<Incident> collection;
        public Incident_DAO()
        {
            this.collection = this.dbServDesk.GetCollection<Incident>("incidents");
        }

        public int countIncidents(String status)
        {
            var unresolvedIncidents = collection.Find(i => i.status == status);
            return (int)unresolvedIncidents.Count();
        }

        public int countAllIncidents()
        {
            var allIncidents = collection.Find(i => true);
            return (int)allIncidents.Count();
        }

        public IFindFluent<Incident, Incident> listIncidents(String status)
        {
            var incidents = collection.Find(i => i.status == status);
            return incidents;
        }
        public IFindFluent<Incident, Incident> listAllIncidents()
        {
            var allIncidents = collection.Find(i => true);
            return allIncidents;
        }

        // Updates the element (filter by id field) in the Mongo database
        public void UpdateTicket(Incident i)
        {
            var filter = Builders<Incident>.Filter.Eq("_id", i._id);
            var newValue = Builders<Incident>.Update.Set("status", i.status).Set("subjectEmail", i.subjectEmail).Set("employeeID", i.employeeID)
                .Set("_id", i._id).Set("subjectID", i.subjectID).Set("dateCreated", i.dateCreated).Set("problemDescription", i.problemDescription);
            collection.UpdateOne(filter, newValue);
        }

        public void InsertTicket(Incident i)
        {
            var doc = new BsonDocument
            {
                {"subjectEmail", i.subjectEmail},
                {"_id", i._id},{"subjectID", 3},
                {"problemDescription", i.problemDescription},
                {"employeeID",i.employeeID},
                {"status", i.status},
                {"dateCreated", i.dateCreated}
            };

            var myObj = BsonSerializer.Deserialize<Incident>(doc);

            collection.InsertOne(myObj);
        }

        public void DeleteTicket(ObjectId id)
        {
            var deleteFilter = Builders<Incident>.Filter.Eq("_id", id);
            collection.DeleteOne(deleteFilter);
        }
    }
}
