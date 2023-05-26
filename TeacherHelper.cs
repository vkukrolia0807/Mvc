using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_helper
{
    public class TeacherHelper
    {
        public  Teachercustom tea(Teacher t)
        {
            Teachercustom teacher = new Teachercustom();
            teacher.fname = t.FirstName;
            teacher.lname = t.LastName;
            teacher.Email = t.EmailId;
            teacher.Dob = t.BirthDate;
            teacher.gender = t.Gender;
            teacher.Address = t.Address;
            teacher.city = t.city;
            teacher.state = t.state;
            teacher.country = t.Country;
            teacher.subject = t.Subject;


            return teacher;
        }

        public Teacher tea1(Teachercustom t1)
        {
            Teacher teacher1 = new Teacher();
            teacher1.FirstName = t1.fname;
            teacher1.LastName = t1.lname;
            teacher1.EmailId = t1.Email;
            teacher1.BirthDate = t1.Dob;
            teacher1.Gender = t1.gender;
            teacher1.Address = t1.Address;
            teacher1.city = t1.city;
            teacher1.state = t1.state;
            teacher1.Country = t1.country;
            teacher1.Subject = t1.subject;


            return teacher1;
        }
    }
}