using System;
using System.Collections.Generic;
using System.Text;
using ServiceDeskDAL;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ServiceDeskController
{
    public class Lanuage_Service
    {
        private Languages_DAL dao = new Languages_DAL();

        public List<Language> listUsers()
        {
            try
            {
                IFindFluent<Language, Language> languages = dao.AllLanguages();
                languages = dao.AllLanguages();

                var res = new List<Language>();
                foreach (var item in languages.ToList())
                {
                    var vi = new Language()
                    {
                        _id = item._id,
                        logOut = item.logOut,
                        labelLanguages = item.labelLanguages,
                        dashboard = item.dashboard,
                        users = item.users
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
    }
}
