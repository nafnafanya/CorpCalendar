using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp_Calendar.Services
{
    public static class DateTimeHelper
    {
        public static DateTime GeDateTime(DateTime datePart, DateTime timePart)
        {
            return new DateTime(datePart.Year, datePart.Month, datePart.Day,
                timePart.Hour, timePart.Minute, timePart.Second);
        }
    }
}
