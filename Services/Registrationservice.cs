using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class Registrationservice : IRegistration
    {
        public bool Register(Registercustom user)
        {
            Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();
            try
            {
                if (db.SchoolUserLogins.Any(x => x.EmailId.Equals(user.Email)) && (db.SchoolUserLogins.Any(x => x.Password.Equals(user.password))))
                {

                    return false;
                }

                else
                {
                    db.add_user(user.fname, user.Email, user.password);
                    return true;
                }
            }

            catch (Exception e)
            {
                throw e;
            }
         
        }
    }
}