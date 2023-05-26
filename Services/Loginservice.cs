using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class Loginservicecontext : ILogin
    {
        public bool Login(Logincustom user)
        {
            Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();
          
                if (db.SchoolUserLogins.Any(x => x.EmailId.Equals(user.Email)) && (db.SchoolUserLogins.Any(x => x.Password.Equals(user.password))))
                {

                    return true;
                }

                else
                {
                   
                    return false;
                }
           
            
            
        }
    }
}