using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_mgmt_Repository.Repositories
{
  public  interface ITeacher
    {
        Teachercustom EditTeacher(int id);
        bool Insert(Teachercustom teacher);
        bool AddTeacher(Teachercustom teacher);

        List<Teacher> getall();
        void DeleteTeacher(int id);
    }
}
