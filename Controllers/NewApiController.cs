using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi_1.Controllers
{
    public class NewApiController : ApiController
    {
        // GET: NewApi
        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult AllStudent()
        {
            List<Student> st = db.Students.ToList();
            return Ok(st);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult AllStudent(int id)
        {
            var obj = db.Students.Where(m => m.Id == id).FirstOrDefault();
            return Ok(obj);
            }

        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllTeacher()
        //{
        //    List<Teacher> st = db.Teachers.ToList();
        //    return Ok(st);
        //}

        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllTeacher(int id)
        //{
        //    var obj = db.Teachers.Where(m => m.Id == id).FirstOrDefault();
        //    return Ok(obj);
        //}
        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllCountry()
        //{
        //    List<Country> st = db.Countries.ToList();
        //    return Ok(st);
        //}

        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllCountry(int id)
        //{
        //    var obj = db.Countries.Where(m => m.CountryId == id).FirstOrDefault();
        //    return Ok(obj);
        //}
        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllState()
        //{
        //    List<State> st = db.States.ToList();
        //    return Ok(st);
        //}

        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllState(int id)
        //{
        //    var obj = db.States.Where(m => m.StateId == id).FirstOrDefault();
        //    return Ok(obj);
        //}
        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllCity()
        //{
        //    List<City> st = db.Cities.ToList();
        //    return Ok(st);
        //}

        //[System.Web.Http.HttpGet]
        //public IHttpActionResult AllCity(int id)
        //{
        //    var obj = db.Cities.Where(m => m.CityId == id).FirstOrDefault();
        //    return Ok(obj);
        //}
    }
}