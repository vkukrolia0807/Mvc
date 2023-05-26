using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class CityService : ICity
    {
        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();
        public List<City> ViewCitylist()
        {
            return db.Cities.ToList();
        }
        public bool AddCity(Citycustom city)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAllCity()
        {
            return db.Cities.ToList();
        }
    }
}