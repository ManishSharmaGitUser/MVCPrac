using MVCHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelper.Controllers
{
    [RoutePrefix("students")]
    public class ConvetionalRoutingController : Controller
    {
        // GET: ConvetionalRouting
        //for attribute routing Please add  routes.MapMvcAttributeRoutes(); in RouteConfig file
        [Route("")] //as students is common in all routing so add this in RoutePrefix before controller
        public ActionResult GetAllStudents()
        {
            var stdents = students();
            return View(stdents);
        }

        [Route("{id:int}")]
        public ActionResult GetStudent(int id)
        {
            var stdrec = students().FirstOrDefault(x => x.Id == id);
            return View(stdrec);
        }

        [Route("{id}/address")] 
        public ActionResult GetStudentAddress(int id)
        {
            var stdaddress = students().Where(x => x.Id == id).Select(x=>x.Address).FirstOrDefault();
            return View(stdaddress);
        }

        [Route("{id}")]
        public string mystring(string id)
        {
            return id;
        }

        [Route("~/about-us")] //here use tild sign for removing RoutePrefix for this route
        public string AboutUS()
        {
            return "this is About us";
        }

        private List<Student> students()
        {
            return new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Manish",
                    Class = "First",
                    Address = new Address{ Address1 = "Manish Address" , City="Kanpur" , HomeNumber="63"}
                },
                 new Student
                {
                    Id = 1,
                    Name = "Kumar",
                    Class = "Second",
                    Address = new Address{ Address1 = "Kumar Address" , City="Lucknow" , HomeNumber="65"}
                },
                  new Student
                {
                    Id = 1,
                    Name = "Ravi",
                    Class = "Third",
                    Address = new Address{ Address1 = "Ravi Address" , City="Noida" , HomeNumber="83"}
                },

            };
        }
    }
}