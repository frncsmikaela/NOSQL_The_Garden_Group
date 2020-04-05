using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDeskModel
{
    public class User
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phone { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public string location { get; set; }
    }
}
