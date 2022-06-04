using System;

namespace Corp_Calendar.Models
{
    public class Employee
    {
        public string FirstName { get; }
        public string SecondName { get; }
        public EmployeeGroup[] Groups { get; }
        public Guid EmployeeId { get; }
        public string FullName => FirstName + " " + SecondName;
        public string GoupNames => GetGroupNames();

        private string GetGroupNames()
        {
            var names = string.Empty;

            for (var index = 0; index < Groups.Length; index++)
            {
                var employeeGroup = Groups[index];

                if (index != 0)
                {
                    names += ",";
                }
                names += employeeGroup.GroupName;
            }

            return names;
        }

        public Employee(Guid employeeId, string firstName, string secondName, EmployeeGroup[] groups)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            SecondName = secondName;
            Groups = groups;
        }
    }
}