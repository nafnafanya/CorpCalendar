using System;

namespace Corp_Calendar.Models
{
    public class EmployeeGroup
    {
        public EmployeeGroup(Guid groupId, string groupName, Employee[] employees)
        {
            GroupId = groupId;
            GroupName = groupName;
            Employees = employees;
        }

        public Employee[] Employees { get; set; }
        public Guid GroupId { get; }
        public string GroupName { get; }
    }
}