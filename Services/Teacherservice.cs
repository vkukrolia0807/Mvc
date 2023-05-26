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
    public class Teacherservice : ITeacher
    {
        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();
        public bool AddTeacher(Teachercustom teacher)
        {
            
            Teachercustom teacher1 = new Teachercustom();
            teacher1.fname = teacher.fname;
            teacher1.lname = teacher.lname;
            teacher1.Mno = teacher.Mno;
            teacher1.Dob = teacher.Dob;
            teacher1.gender = teacher.gender;
            teacher1.Email = teacher.Email;
            teacher1.Address = teacher.Address;
            teacher1.city = teacher.city;
            teacher1.state = teacher.state;
            teacher1.country = teacher.country;
            teacher1.subject = teacher.subject;

            db.sp_add_teacher(teacher.fname, teacher.lname, teacher.Mno, teacher.Email, teacher.Dob , teacher.gender, teacher.Address, teacher.city, teacher.state, teacher.country, teacher.subject);
            
            return true;

        }

        public void DeleteTeacher(int id)
        {

            db.Teachers.Remove(db.Teachers.Find(id));
            db.SaveChanges();
        }

        public Teachercustom EditTeacher(int id)
        {
            TeacherHelper st = new TeacherHelper();
            return st.tea(db.Teachers.Where(x => x.Id == x.Id).FirstOrDefault());
        }

        public List<Teacher> getall()
        {
            return db.Teachers.ToList();
        }

        public bool Insert(Teachercustom teacher)
        {
            Teachercustom teacher1 = new Teachercustom();
            teacher1.id = teacher.id;
            teacher1.fname = teacher.fname;
            teacher1.lname = teacher.lname;
            teacher1.Mno = teacher.Mno;
            teacher1.Dob = teacher.Dob;
            teacher1.gender = teacher.gender;
            teacher1.Email = teacher.Email;
            teacher1.Address = teacher.Address;
            teacher1.city = teacher.city;
            teacher1.state = teacher.state;
            teacher1.country = teacher.country;
            teacher1.subject = teacher.subject;

            db.UPDATE_Teacher(teacher.id,teacher.fname, teacher.lname, teacher.Mno, teacher.Email, teacher.Dob, teacher.gender, teacher.Address, teacher.city, teacher.state, teacher.country, teacher.subject);

            return true;
        }
    }
}