using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelper.Controllers
{
    public class PassDataFromViewToControlerController : Controller
    {
        // GET: PassDataFromViewToControler
        public ActionResult UsingParameter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UsingParameter(string firstname ,string lastname)
        {
            //Or Use Request to get data from View

            var fname = Request["firstname"];
            var lname = Request["lastname"];
            return View();
        }

        //In this getting data from view to controller using FormCollection
        public ActionResult UsingFormCollection()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UsingFormCollection(FormCollection form)
        {
            var fname = form["firstname"];
            var lname = form["lastname"];
            return View();

        }

        //4 th method is using Model and stronly binding
    }
}