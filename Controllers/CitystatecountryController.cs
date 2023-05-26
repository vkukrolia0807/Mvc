using Student_mgmt_Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_mgmt.Controllers
{
    [Authorize]
    public class CitystatecountryController : Controller
    {
        // GET: Citystatecountry
        private readonly Vidhi335_schoolmgmtEntities Db;

        public CitystatecountryController()
        {
            Db = new Vidhi335_schoolmgmtEntities();
        }


        // GET: Countries
        public ActionResult GetCountries()
        {
            var countries = Db.Countries.Select(c => new { c.CountryId, c.CountryName }).ToList();
            return Json(countries, JsonRequestBehavior.AllowGet);
        }

        // GET: States
        public ActionResult GetStates(int countryID)
        {
            Db.Configuration.ProxyCreationEnabled = false;
            var states = Db.States.Where(c => c.CountryId == countryID).ToList();
            return Json(states, JsonRequestBehavior.AllowGet);
        }

        // GET: Cities
        public ActionResult GetCities(int stateID)
        {
            Db.Configuration.ProxyCreationEnabled = false;
            var cities = Db.Cities.Where(c => c.StateId == stateID).Select(c => new { c.CityId, c.CityName }).ToList();
            return Json(cities, JsonRequestBehavior.AllowGet);
        }

    }
}