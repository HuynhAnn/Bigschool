using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime datatime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),"dd/M/yyyy",CultureInfo.CurrentCulture,DateTimeStyles.None,out datatime);
            return (isValid && datatime>DateTime.Now);
        }
        
        
    }
}