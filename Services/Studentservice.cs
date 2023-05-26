using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using Student_mgmt_helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class Studentservice : IStudent
    {
        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();

       

     
       

        public bool Addstudent(Studentcustom student)
        {
            Student student1 = new Student();
            student1.FirstName = student.fname;
            student1.LastName = student.lname;
            student1.EmailId = student.Email;
            student1.PhoneNumber = student.Mno;
            student1.BirthDate = student.Dob;
            student1.Gender = student.gender;
            student1.Address = student.Address;
            student1.city = student.city;
            student1.state = student.state;
            student1.Country = student.country;
            student1.teacher = student.teacher;

            db.sp_add_student(student.fname, student.lname, student.Mno, student.Email, student.Dob, student.gender, student.Address, student.country, student.state, student.city, student.teacher);
            return true;
           
        }

        public List<Student> GetAllStudent()
        {
          return  db.Students.ToList();
        }

        public Studentcustom EditStudent(int id)
        {
            StudentHelper st = new StudentHelper();
            return  st.st(db.Students.Where(x => x.Id == x.Id).FirstOrDefault());
        }


        public bool Insert(Studentcustom student)
        {
            Student student1 = new Student();
            student1.Id = student.id;
            student1.FirstName = student.fname;
            student1.LastName = student.lname;
            student1.EmailId = student.Email;
            student1.PhoneNumber = student.Mno;
            student1.BirthDate = student.Dob;
            student1.Gender = student.gender;
            student1.Address = student.Address;
            student1.city = student.city;
            student1.state = student.state;
            student1.Country = student.country;
            student1.teacher = student.teacher;

        
            db.UPDATE_DATA(student.id,student.fname, student.lname, student.Mno, student.Email, student.Dob, student.gender, student.Address, student.country, student.state, student.city, student.teacher);
            return true;
        }

        public void DeleteStudent(int id)
        {

             db.Students.Remove(db.Students.Find(id));
            db.SaveChanges();
        }
    }
}