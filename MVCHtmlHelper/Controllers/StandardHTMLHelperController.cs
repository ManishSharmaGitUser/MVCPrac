using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelper.Controllers
{
    public class StandardHTMLHelperController : Controller
    {
        // GET: StandardHTMLHelper
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string name=null)
        {
            return View();
        }
    }
}