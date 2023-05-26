using PagedList;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_mgmt.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        //public StudentController() { }
        public IStudent studenthelper;
        public ITeacher teacherhelper;
        public ICountry Countryhelper;
        public IState Statehelper;
        public ICity cityhelper;
        public ISubject subjecthelper;

        public StudentController(IStudent studentrepo,ITeacher teacherrepo,ICountry countryrepo,IState staterepo,ICity cityrepo,ISubject subjectrepo)
        {
            studenthelper = studentrepo;
            teacherhelper = teacherrepo;
            Countryhelper = countryrepo;
            Statehelper = staterepo;
                cityhelper = cityrepo;
            subjecthelper = subjectrepo;
        }
        // GET: Student
        public ActionResult Addstudnt()
        {
            try
            {
                var x = Countryhelper.ViewCountrylist();
                ViewBag.CountryName = new SelectList(x, "CountryId", "CountryName");
                var y = Statehelper.ViewStates();
                ViewBag.StateName = new SelectList(y, "StateId", "StateName");
                var z = cityhelper.ViewCitylist();
                ViewBag.CityName = new SelectList(z, "CityId", "CityName");
                ViewBag.TeacherName = new SelectList(teacherhelper.getall(), "Id", "FirstName");
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public ActionResult Addstudnt(Studentcustom student, FormCollection form)
        {
            try
            {
                student.teacher = "";
                student.teacher = form["teacher"];
                if (studenthelper.Addstudent(student))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult AddTeacher()
        {
            var x = Countryhelper.ViewCountrylist();
            ViewBag.CountryName = new SelectList(x, "CountryId", "CountryName");
            var y = Statehelper.ViewStates();
            ViewBag.StateName = new SelectList(y, "StateId", "StateName");
            var z = cityhelper.ViewCitylist();
            ViewBag.CityName = new SelectList(z, "CityId", "CityName");
            ViewBag.SubjectName = new SelectList(subjecthelper.getall(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult AddTeacher(Teachercustom teacher, FormCollection form)
        {
            try
            {
                teacher.subject = "";
                teacher.subject = form["subject"];
                if (teacherhelper.AddTeacher(teacher))
                {
                    return RedirectToAction("INDEX", "Home");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult AllStudent(int? i)
        {
            try
            {
                
                return View(studenthelper.GetAllStudent().ToPagedList(i?? 1,3));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult AllTeacher()
        {
            try
            {
                return View(teacherhelper.getall());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult EditStudent(int id)
        {
            try
            {
                var x = Countryhelper.ViewCountrylist();
                ViewBag.CountryName = new SelectList(x, "CountryId", "CountryName");
                var y = Statehelper.ViewStates();
                ViewBag.StateName = new SelectList(y, "StateId", "StateName");
                var z = cityhelper.ViewCitylist();
                ViewBag.CityName = new SelectList(z, "CityId", "CityName");
                ViewBag.TeacherName = new SelectList(teacherhelper.getall(), "Id", "FirstName");

                return View(studenthelper.EditStudent(id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public ActionResult EditStudent(Studentcustom student)
        {
            try
            {
                if (studenthelper.Insert(student))
                {
                    return RedirectToAction("INDEX", "Home");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ActionResult EditTeacher(int id)
        {
            try
            {
                var x = Countryhelper.ViewCountrylist();
                ViewBag.CountryName = new SelectList(x, "CountryId", "CountryName");
                var y = Statehelper.ViewStates();
                ViewBag.StateName = new SelectList(y, "StateId", "StateName");
                var z = cityhelper.ViewCitylist();
                ViewBag.CityName = new SelectList(z, "CityId", "CityName");
                ViewBag.SubjectName = new SelectList(subjecthelper.getall(), "Id", "Name");

                return View(teacherhelper.EditTeacher(id));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public ActionResult EditTeacher(Teachercustom teacher)
        {
            try
            {
                if (teacherhelper.Insert(teacher))
                {
                    return RedirectToAction("INDEX", "Home");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult DeleteStudent(int id)
        {
            try
            {
                studenthelper.DeleteStudent(id);
                return RedirectToAction("AllStudent");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ActionResult DeleteTeacher(int id)
        {
            try
            {
                teacherhelper.DeleteTeacher(id);
                return RedirectToAction("AllStudent");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

