using System;
using System.Collections;
using System.Collections.Generic;
using Corp_Calendar.Models;

namespace Corp_Calendar.Services
{
    /// <summary>
    /// Service to access employees data
    /// </summary>
    public class EmployeeService
    {
        public Employee[] GetEmployees()
        {
            // TODO Real data from database
            return CalendarDemoData.Employees.ToArray();
        }

        public Employee GetEmployeeById(Guid id)
        {
            var allEmployees = GetEmployees();

            foreach (var employee in allEmployees)
            {
                if (employee.EmployeeId == id)
                {
                    return employee;
                }
            }

            return null;
        }

        public CalendarInfo[] GetEmployeesAndGroupCalendars()
        {
            var infos = new List<CalendarInfo>();

            // TODO Real data from database
            var employees = CalendarDemoData.Employees.ToArray();
            var employeeGroups = CalendarDemoData.EmployeeGroups.ToArray();

            foreach (var employee in employees)
            {
                infos.Add(new CalendarInfo(employee.FullName, employee.EmployeeId));
            }

            foreach (var employeeGroup in employeeGroups)
            {
                infos.Add(new CalendarInfo(employeeGroup.GroupName, employeeGroup.GroupId, true));
            }

            return infos.ToArray();
        }

        public Employee[] GetEmployesByIdGroupId(Guid calendarInfoCalendarId)
        {
            foreach (var group in CalendarDemoData.EmployeeGroups)
            {
                if (group.GroupId == calendarInfoCalendarId)
                {
                    return group.Employees;
                }
            }

            return new Employee[0];
        }
    }
}
