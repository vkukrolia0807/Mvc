using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class Stateservice : IState
    {
        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();
        public bool addstate(Statecustom state)
        {
            throw new NotImplementedException();
        }

        public List<State> GetAllStates()
        {
            return db.States.ToList();
        }

        public List<State> ViewStates()
        {
           return db.States.ToList();
        }
    }
}