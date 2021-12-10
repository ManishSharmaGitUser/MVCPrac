using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHtmlHelper.Models
{
    public class ValidationModel
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Plase Enter Email")]
        [EmailAddress(ErrorMessage ="Email is not Correct")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter age")]
        [Range(18,100)]
        public int Age { get; set; }
    }
}