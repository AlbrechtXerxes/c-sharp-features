using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10Features
{
    public class DateAndTimeFeature
    {
        public static void SomeMethod()
        {
            var dateTime = new DateTime(2022, 1, 1, 12, 30, 40, 5);//"Saturday, 1 January 2022 12:30:40"
            var dateOnly = new DateOnly(2022, 1, 1);//"Saturday, 1 January 2022"
            var timeOnly = new TimeOnly(12, 30, 40, 5);//"12:30:40"

            var dateTimeString = dateTime.ToLongDateString() + " " + dateTime.ToLongTimeString();
            var dateOnlyString = dateOnly.ToLongDateString();
            var timeOnlyString = timeOnly.ToLongTimeString();
            //Notes:
            //We split complex DateTime into two separated objects.
            //It's now more elegant solution.
        }
    }
}
