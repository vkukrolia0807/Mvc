using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_mgmt_Repository.Repositories
{
  public  interface IStudent
    {
        bool Addstudent(Studentcustom student);

        bool Insert(Studentcustom student);

        List<Student> GetAllStudent();

        Studentcustom EditStudent(int id);

        void DeleteStudent(int id);
    }
}
