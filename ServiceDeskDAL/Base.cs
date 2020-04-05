using System;
using System.Windows.Forms;
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
                    MessageBox.Show("failed to connect to database" + e.ToString());
                }

            }
            return instance;
        }
    }

}


