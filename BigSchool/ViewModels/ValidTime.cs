using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web;

namespace BigSchool.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime datatime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture,DateTimeStyles.None, out datatime);
            return isValid ;
        }
    }

}