using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_mgmt_Repository.Repositories
{
   public  interface ILogin
    {

        bool Login(Logincustom user);

    }
}
