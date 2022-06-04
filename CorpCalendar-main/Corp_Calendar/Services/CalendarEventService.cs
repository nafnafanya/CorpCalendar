using System;
using System.Collections.Generic;
using System.Linq;
using Corp_Calendar.Models;

namespace Corp_Calendar.Services
{
    /// <summary>
    /// Service to access employees events data
    /// </summary>
    public class CalendarEventService
    {
        public CalendarEvent[] GetAllEvents()
        {
            // TODO Real data from database
            return CalendarDemoData.Events.ToArray();
        }


        public CalendarEvent[] GetCalendarEvents(List<CalendarInfo> calendarFilter)
        {
            var filteredEvents = new List<CalendarEvent>();

            foreach (var calendarInfo in calendarFilter)
            {
                var events = GetCalendarEvents(calendarInfo.CalendarId, calendarInfo.IsGroup);

                foreach (var calendarEvent in events)
                {
                    var eventAlreadyAdded = IsEventAlreadyAdded(filteredEvents, calendarEvent);

                    if (!eventAlreadyAdded)
                    {
                        filteredEvents.Add(calendarEvent);
                    }
                }
            }

            return filteredEvents.ToArray();
        }

        public CalendarEvent[] GetCalendarEvents(Guid memberIdFilter, bool isGroupCalendar)
        {
            var allEvents = GetAllEvents();
            var filteredEvents = new List<CalendarEvent>();

            
            foreach (var calendarEvent in allEvents)
            {
                foreach (var memberId in calendarEvent.Members)
                {
                    if (memberId == memberIdFilter)
                    {
                        var eventAlreadyAdded = IsEventAlreadyAdded(filteredEvents, calendarEvent);

                        if (!eventAlreadyAdded)
                        {
                            filteredEvents.Add(calendarEvent);
                        }
                    }

                    if (!isGroupCalendar)
                    {
                        var employeeGroups = ServiceContainer.EmployeeService.GetEmployeeById(memberIdFilter)?.Groups;

                        if (employeeGroups == null)
                        {
                            employeeGroups = new EmployeeGroup[0];
                        }

                        if (employeeGroups.Length > 0)
                        {
                            foreach (var group in employeeGroups)
                            {
                                var events = GetCalendarEvents(group.GroupId, true);

                                foreach (var ev in events)
                                {
                                    var eventAlreadyAdded = IsEventAlreadyAdded(filteredEvents, ev);

                                    if (!eventAlreadyAdded)
                                    {
                                        filteredEvents.Add(ev);
                                    }
                                }
                            }
                        }
                    }

                }
            }

            return filteredEvents.ToArray();
        }

        private static bool IsEventAlreadyAdded(List<CalendarEvent> filteredEvents, CalendarEvent ev)
        {
            bool eventAlreadyAdded = false;

            foreach (var e in filteredEvents)
            {
                if (e.EventId == ev.EventId)
                {
                    eventAlreadyAdded = true;
                    break;
                }
            }

            return eventAlreadyAdded;
        }


        public void CreateOrUpdate(CalendarEvent calendarEvent)
        {
            var oldEvent = GetEvenById(calendarEvent.EventId);

            if (oldEvent != null)
            {
                UpdateEvent(calendarEvent);
            }
            else
            {
                AddEvent(calendarEvent);
            }
        }

        public void Delete(CalendarEvent calendarEvent)
        {
            // TODO Real data from database
            var e = CalendarDemoData.Events.FirstOrDefault(e => e.EventId == calendarEvent.EventId);
            if (e != null)
            {
                CalendarDemoData.Events.Remove(e);
            }
        }

        private void AddEvent(CalendarEvent calendarEvent)
        {
            // TODO Real data from database
            CalendarDemoData.Events.Add(calendarEvent);
        }

        private void UpdateEvent(CalendarEvent calendarEvent)
        {
            Delete(calendarEvent);
            AddEvent(calendarEvent);
        }

        private CalendarEvent GetEvenById(Guid calendarEventEventId)
        {
            var allEvents = GetAllEvents();

            foreach (var calendarEvent in allEvents)
            {
                if (calendarEvent.EventId == calendarEventEventId)
                {
                    return calendarEvent;
                }
            }

            return null;
        }
        
        public TimeSlot[] SearchAvailableTime(DateTime dateFromSearch, DateTime dateToSearch, List<CalendarInfo> members)
        {
            var filteredEvents = GetCalendarEvents(members);

            if (filteredEvents.Length == 0)
            {
                return new TimeSlot[]
                {
                    new TimeSlot(dateFromSearch,DateTime.Now.AddHours(1))
                };
            }
            else
            {
                // TODO SEARCH TIME
                return new TimeSlot[]
                {
                    new TimeSlot(dateFromSearch,DateTime.Now.AddHours(1))
                };
            }

            return new TimeSlot[0];
        }
    }
}
