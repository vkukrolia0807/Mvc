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
    public class CountrystatecityController : Controller
    {
        public ICountry Countryhelper;
        public IState Statehelper;
        public ICity cityhelper;
        public CountrystatecityController(ICountry countryrepo,IState staterepo,ICity cityrepo)
        {
            Countryhelper = countryrepo;
            Statehelper = staterepo;
            cityhelper=cityrepo;
        }
        // GET: Countrystatecity
        public ActionResult AddCountry()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public ActionResult AddCountry(Countrycustom country)
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ActionResult AddState()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddState(Statecustom state)
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
        public ActionResult AddCity()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public ActionResult AddCity(Citycustom city)
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ActionResult AllCountry()
        {
            try
            {
                return View(Countryhelper.GetAll());
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public ActionResult AllState()
        {
            try
            {
                return View(Statehelper.GetAllStates());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ActionResult AllCity()
        {
            try
            {
                return View(cityhelper.GetAllCity());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}