using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_helper
{
    public class Loginregisterhelper
    {
        public Logincustom UserData(SchoolUserLogin SU)
        {
            Logincustom S = new Logincustom();
            S.Email = SU.EmailId;
            S.password = SU.Password;

            return S;
        }
        public Registercustom Register1(SchoolUserLogin SU)
        {

            Registercustom S = new Registercustom();
            S.fname = SU.FName;
            S.Email = SU.EmailId;
            S.password = SU.Password;

            return S;
        }
    }
}