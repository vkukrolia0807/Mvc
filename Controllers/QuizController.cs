using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_mgmt.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Quiz()
        {
            return View();
        }
    }
}