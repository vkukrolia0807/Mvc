using Student_mgmt_Model.Context;
using Student_mgmt_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_mgmt_helper
{
    public class CountryHelper
    {
        public Countrycustom ConvertToCustomCSC(Country country)
        {
            Countrycustom CSC = new Countrycustom();
            CSC.id = country.CountryId;
            CSC.countryname = country.CountryName;
            return CSC;
        }
        public Country ConvertToDBCSC(Countrycustom CSC)
        {
            Country country = new Country();
            country.CountryId = CSC.id;
            country.CountryName = CSC.countryname;
            return country;
        }

        public Statecustom ConvertToDBCtate(State State)
        {
            Statecustom state1 = new Statecustom();
            state1.stateid = State.StateId;
            state1.statename = State.StateName;
            return state1;
        }
        public State Converttocustomstate(Statecustom state1)
        {
            State state = new State();
            state.StateId = state1.stateid;
            state.StateName = state1.statename;
            return state;
        }

        public Citycustom convertodb(City city)
        {
            Citycustom city1 = new Citycustom();
            city1.id = city.CityId;
            city1.cityname = city.CityName;
            return city1;
        }

        public City Converttocustomcity(Citycustom city1)
        {
            City city = new City();
            city1.id = city1.id;
            city1.cityname = city1.cityname;
            return city;
        }
    }
}