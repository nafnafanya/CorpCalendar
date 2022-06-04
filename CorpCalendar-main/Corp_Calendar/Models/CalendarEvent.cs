using System;

namespace Corp_Calendar.Models
{
    public class CalendarEvent
    {
        public Guid EventId { get; set; }

        /// <summary>
        ///     Employee or group id
        /// </summary>
        public Guid[] Members { get; set; } = new Guid[0];

        public string Description { get; set; }
        public string Place { get; set; }
        public string Intent { get; set; }
        public string Subject { get; set; }

        public DateTime DateFrom { get; set; } = DateTime.Today;
        public DateTime DateTo { get; set; } = DateTime.Today;

        public string GetDatesInfo()
        {
            return DateFrom.ToShortDateString() 
                   + " " 
                   + DateFrom.ToShortTimeString()
                   + " - " 
                   + DateTo.ToShortDateString()
                   + " "
                   + DateTo.ToShortTimeString();
        }

        public CalendarEvent(Guid eventId, string subject, Guid[] members)
        {
            EventId = eventId;
            Subject = subject;
            Members = members;
        }

        public CalendarEvent(Guid eventId)
        {
            EventId = eventId;
        }
    }
}