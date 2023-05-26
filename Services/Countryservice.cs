using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_Repository.Services
{
    public class Countryservice : ICountry
    {

        Vidhi335_schoolmgmtEntities db = new Vidhi335_schoolmgmtEntities();

        public bool AddCountry(Countrycustom country)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            return db.Countries.ToList();
        }

        public List<Country> ViewCountrylist()
        {
            return db.Countries.ToList();
        }
    }
}