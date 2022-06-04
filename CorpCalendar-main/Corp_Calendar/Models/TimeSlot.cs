using System;

namespace Corp_Calendar.Models
{
    public class TimeSlot
    {
        public TimeSlot(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}