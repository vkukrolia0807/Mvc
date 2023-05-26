using Student_mgmt_Model.Context;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class Subjectservice : ISubject
    {
        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();
        public List<subject> getall()
        {
           return db.subjects.ToList();
        }
    }
}