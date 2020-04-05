using System;
using System.Collections.Generic;
using System.Text;
using ServiceDeskDAL;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ServiceDeskController
{
    public class User_Service
    {
        private User_DAO dao = new User_DAO();

        public List<User> listUsers()
        {
            try
            {
                IFindFluent<User, User> users;
                users = dao.retrieveUsers();

                var res = new List<User>();
                foreach (var item in users.ToList())
                {
                    var vi = new User()
                    {
                        _id = item._id,
                        email = item.email,
                        firstName = item.firstName,
                        lastName = item.lastName,
                        phone = item.phone,
                        type = item.type,
                        location = item.location

                    };
                    res.Add(vi);
                }
                return res;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool Exists(int phone)
        {
            try
            {
               bool check = dao.Exists(phone);
                return check;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void UpdateUser(User u)
        {
            try
            {
                dao.UpdateUser(u);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
