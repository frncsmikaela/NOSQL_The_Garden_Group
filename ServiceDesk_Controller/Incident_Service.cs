﻿using System;
using System.Collections.Generic;
using ServiceDeskDAL;
using ServiceDeskModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ServiceDeskController
{
    public class Incident_Service
    {
        private Incident_DAO dao = new Incident_DAO();

        public int CountUnresolvedIncidents(String status)
        {
            try
            {
                int countIncidents = dao.CountUnresolvedIncidents(status);
                return countIncidents;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int countAllIncidents()
        {
            try
            {
                int countAllIncidents = dao.CountAllIncidents();
                return countAllIncidents;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ViewIncident> listIncidents(String status = null)
        {
            try
            {
                IFindFluent<Incident, Incident> incidents;
                if (status == null)
                {
                    incidents = dao.ListAllIncidents();
                }
                else
                {
                    incidents = dao.ListIncidents(status);
                }
                var res = new List<ViewIncident>();
                foreach (var item in incidents.ToList())
                {
                    var vi = new ViewIncident()
                    {
                        id = item._id.ToString(),
                        subjectID = item.subjectID,
                        subjectEmail = item.subjectEmail,
                        employeeID = item.employeeID,
                        dateCreated = item.dateCreated,
                        dateDeadline = item.dateDeadline,
                        status = item.status,
                        problemDescription = item.problemDescription
                        

                    };
                    res.Add(vi);
                }
                return res;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void UpdateTicket(ViewIncident i)
        {
            var inc = new Incident()
            {

                _id = ObjectId.Parse(i.id),
                subjectID = i.subjectID,
                employeeID = i.employeeID,
                dateCreated = i.dateCreated,
                dateDeadline = i.dateDeadline,
                status = i.status,
                problemDescription = i.problemDescription,
                subjectEmail = i.subjectEmail
            };
            dao.UpdateTicket(inc);
        }

        public void InsertTicket(ViewIncident i)
        {
            var inc = new Incident()
            {
                employeeID = i.employeeID,
                dateCreated = i.dateCreated,
                dateDeadline = i.dateDeadline,
                status = i.status,
                problemDescription = i.problemDescription,
                subjectEmail = i.subjectEmail,
                // For now, subject ID is just 3
                subjectID = 3
        };
            dao.InsertTicket(inc);
        }

        public void DeleteTicket(string id)
        {
            var _id = ObjectId.Parse(id);
            dao.DeleteTicket(_id);
        }


        public class ViewIncident
        {
            public string id { get; set; }
            public int employeeID { get; set; }
            public int subjectID { get; set; }
            public string subjectEmail { get; set; }
            public DateTime dateCreated { get; set; }
            public DateTime dateDeadline { get; set; }
            public string status { get; set; }
            public string problemDescription { get; set; }
        }

    }
}
