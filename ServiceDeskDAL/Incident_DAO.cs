using System;
using System.Collections.Generic;
using System.Text;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace ServiceDeskDAL
{
    public class Incident_DAO
    {
        private IMongoCollection<Incident> collection;
        public Incident_DAO()
        {
            MongoClient conn = Base.GetInstance();
            IMongoDatabase dbServDesk = conn.GetDatabase("servicedesk");
             collection = dbServDesk.GetCollection<Incident>("incidents");
        }

        public int CountUnresolvedIncidents(String deadlineStatus)
        {
            if (deadlineStatus == "PastDeadline")
            {
                // Return all unresolved tickets past deadline
                var unresolvedIncidents = collection.Find(i => (i.status == "Unresolved") && (i.dateDeadline < DateTime.Now));
                return (int)unresolvedIncidents.Count();
            }
            else
            {
                // Return all unresolved tickets before deadline
                var unresolvedIncidents = collection.Find(i => (i.status == "Unresolved") && (i.dateDeadline >= DateTime.Now));
                return (int)unresolvedIncidents.Count();
            }
        }

        public int CountAllIncidents()
        {
            var allIncidents = collection.Find(i => true);
            return (int)allIncidents.Count();
        }

        // List all unresolved incidents.
        // If the deadline status is "PastDeadline", return those that are past deadline
        // Else return those that are still before the deadline
        public IFindFluent<Incident, Incident> ListIncidents(String deadlineStatus)
        {
            if (deadlineStatus == "PastDeadline")
            {
                var incidents = collection.Find(i => (i.status == "Unresolved") && (i.dateDeadline < DateTime.Now));
                return incidents;
            }
            else
            {
                var incidents = collection.Find(i => (i.status == "Unresolved") && (i.dateDeadline >= DateTime.Now));
                return incidents;
            }

           
        }
        public IFindFluent<Incident, Incident> ListAllIncidents()
        {
            var allIncidents = collection.Find(i => true);
            return allIncidents;
        }

        // Updates the element (filter by id field) in the Mongo database
        public void UpdateTicket(Incident i)
        {
            var filter = Builders<Incident>.Filter.Eq("_id", i._id);
            var newValue = Builders<Incident>.Update.Set("status", i.status).Set("subjectEmail", i.subjectEmail).Set("employeeID", i.employeeID)
                .Set("_id", i._id).Set("subjectID", i.subjectID).Set("dateDeadline", i.dateDeadline).Set("problemDescription", i.problemDescription);
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
                {"dateDeadline", i.dateDeadline}
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
