using System;

namespace Corp_Calendar.Models
{
    public class CalendarInfo
    {
        public string Name { get; }
        public Guid CalendarId { get; }
        public bool IsGroup { get; }

        public CalendarInfo(string name, Guid calendarId)
        {
            Name = name;
            CalendarId = calendarId;
        }

        public CalendarInfo(string name, Guid calendarId, bool isGroup)
        {
            Name = name;
            CalendarId = calendarId;
            IsGroup = isGroup;
        }
    }
}