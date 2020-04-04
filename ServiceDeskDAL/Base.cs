using System;
using MongoDB.Driver;

namespace ServiceDeskDAL
{
    public class Base
    {
        private static MongoClient instance = null;

        private Base() { }
        public static MongoClient GetInstance()
        {

            if (instance == null)
            {
                try
                {
                    instance = new MongoClient("mongodb+srv://admin:admin@cluster0-6vgii.mongodb.net/test?retryWrites=true&w=majority");
                }
                catch (Exception e)
                {
                    
                }

            }
            return instance;
        }
    }

}


