using MVCHtmlHelper.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVCHtmlHelper.Models
{
    public class Employee
    {
        [CustomValidationModel(ErrorMessage ="manish word is required")]
        public string Name { get; set; }

        public string Address { get; set; }

        public bool IsEmployee { get; set; }

    }
}