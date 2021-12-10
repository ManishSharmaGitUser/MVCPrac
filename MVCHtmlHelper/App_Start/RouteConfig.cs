using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCHtmlHelper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //for attribute routing in mvc we add below line  
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name:"allstudents",
            //    url: "students",  //use this in url for accessing
            //    defaults: new { Controller = "ConvetionalRouting", action = "GetAllStudents" }
            //    );
           
            //routes.MapRoute(
            //   name: "GetStudent",
            //   url: "GetStudent/{id}",  //use this in url for accessing
            //   defaults: new { Controller = "ConvetionalRouting", action = "GetStudent" ,id=2 } //passing default value for id
            //   );
           
            //routes.MapRoute(
            //  name: "GetStudentAddress",
            //  url: "GetStudent/{id}/Address",  //use this in url for accessing
            //  defaults: new { Controller = "ConvetionalRouting", action = "GetStudentAddress" },
            //  constraints:new { id=@"\d+"} //we use contraints for only int passing in url otherwise invalid
            //  );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
