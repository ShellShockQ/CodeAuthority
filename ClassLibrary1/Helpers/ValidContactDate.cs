using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Text.RegularExpressions;


namespace CA.BusinessLogic.Helpers
{
    using Detrick.Common.Core;

    public class ValidContactDate: ValidationAttribute
    {
        public override bool IsValid(object dateAndTime)
        {
            try
            {
                DateTime strDateTime = (DateTime)dateAndTime;
                DayOfWeek dayPassedIn = strDateTime.DayOfWeek;
                TimeSpan workDayStart = new TimeSpan(9, 0, 0);
                TimeSpan workDayend = new TimeSpan(18, 0, 0);
                var timePassedIn = strDateTime.TimeOfDay;

                if (strDateTime <= DateTime.Now)
                {
                    return false;
                }

                if ((dayPassedIn == DayOfWeek.Saturday) || (dayPassedIn == DayOfWeek.Sunday))
                {
                    return false;
                }

                if ((timePassedIn >= workDayend) || (timePassedIn <= workDayStart))
                {
                    return false;
                }
                
             return true;
            }
            catch
            {

                return false;
            }


        }
    }
}