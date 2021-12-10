using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelper.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            TempData["MyData"] = "Data from Index Method";
            return View();
        }

        public ActionResult Index1()
        {
            Session.Abandon(); //if we close session in application then tempdata will not work
            ViewBag.MyKey = TempData["MyData"];
            TempData.Keep(); //Holds All Values that are defined by TempData

            //good to go with 

            TempData.Keep("MyData");
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.MyKeyIndex2 = TempData["MyData"];
            return View();
        }
    }
}