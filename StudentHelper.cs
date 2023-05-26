using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_helper
{
    public class StudentHelper
    {
        public static Student Student { get; set; }

        //db to custom
        public Studentcustom st(Student s)
        {
            Studentcustom stu = new Studentcustom();
            stu.fname = s.FirstName;
            stu.lname = s.LastName;
            stu.Mno = s.PhoneNumber;
            stu.Email = s.EmailId;
            stu.gender = s.Gender;
            stu.Dob = s.BirthDate;
            stu.Address = s.Address;
            stu.city = s.city;
            stu.state = s.state;
            stu.country = s.Country;
            stu.teacher = s.teacher;

            return stu;
        }
        //db to custom
        public Student st1(Studentcustom s)
        {
            Student stu1 = new Student();
            stu1.FirstName = s.fname;
            stu1.LastName = s.lname;
            stu1.PhoneNumber = s.Mno;
            stu1.EmailId = s.Email;
            stu1.Gender = s.gender;
            stu1.BirthDate = s.Dob;
            stu1.Address = s.Address;
            stu1.city = s.city;
            stu1.state = s.state;
            stu1.Country = s.country;
            stu1.teacher = s.teacher;

            return stu1;
        }
    }
}