using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDeskModel
{
    public class Language
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string logOut { get; set; }
        public string labelLanguages { get; set; }
        public string dashboard { get; set; }
        public string users { get; set; }
    }
}
