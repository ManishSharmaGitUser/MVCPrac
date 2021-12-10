using MVCHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelper.Controllers
{
    public class LoslyBindingValidationController : Controller
    {
        // GET: LoslyBindingValidation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ValidationModel model)
        {

            return View();
        }
    }
}