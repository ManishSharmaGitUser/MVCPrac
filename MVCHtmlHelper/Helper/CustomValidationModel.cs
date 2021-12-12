using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHtmlHelper.Helper
{
    public class CustomValidationModel :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //in value model prop on which this validation is applicable comes and in ValidationContext all class means model class comes
            if (value!=null)
            {
                string str = value.ToString();
                if (str.Contains("manish"))
                {
                    return ValidationResult.Success;
                }
                
            }

            ErrorMessage = ErrorMessage ?? validationContext.DisplayName+" Field must contain word - manish";
            return new ValidationResult(ErrorMessage);
        }
    }
}