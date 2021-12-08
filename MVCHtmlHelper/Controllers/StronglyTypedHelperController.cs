using MVCHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelper.Controllers
{
    public class StronglyTypedHelperController : Controller
    {
        // GET: StronglyTypedHelper
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee model)
        {

            return View();
        }
    }
}