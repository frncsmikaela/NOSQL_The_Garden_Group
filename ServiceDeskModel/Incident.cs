using System;

namespace ServiceDeskModel
{
    public class Incident
    {

        public MongoDB.Bson.ObjectId _id { get; set; }
        public int employeeID { get; set; }
        public int subjectID { get; set; }
        public string subjectEmail { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateDeadline { get; set; }
        public string status { get; set; }
        public string problemDescription { get; set; }

    }
}
