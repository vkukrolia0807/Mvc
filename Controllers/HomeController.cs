using Student_mgmt_Model.Models;
using Student_mgmt_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Student_mgmt.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }
        public ILogin loginhelper;
        public IRegistration registerheleper;


        public HomeController(ILogin loginrepo, IRegistration registerrepo)
        {
            loginhelper = loginrepo;
            registerheleper = registerrepo;
        }

        public ActionResult Register()
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
        public ActionResult Register(Registercustom registeruser)
        {
            try
            {
                if (registerheleper.Register(registeruser))
                {

                    ViewBag.Notification = "register succesfull";

                    return RedirectToAction("Home", "Login");

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

        public ActionResult Login()
        {
            try
            {
                if (Session["username"] != null)
                {
                    return RedirectToAction("Index", "Home", new { user = Session["username"].ToString() });
                }
                else
                {
                    ViewBag.message = "Invalid login";
                    return View();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        public ActionResult Login(Logincustom user)
        {
            try
            {
                if (loginhelper.Login(user))
                {
                    FormsAuthentication.SetAuthCookie(user.Email, false);
                    ViewBag.Notification = "login succesfull";
                    Session["Username"] = user.Email;
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ViewBag.Notification = "Wrong credintial";
                    return View();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ActionResult Index()
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
    }
}