﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class FuturaDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime DateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out DateTime);
            return (isValid && DateTime > DateTime.Now);
        }
    }
}