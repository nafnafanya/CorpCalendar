using System;
using System.Collections.Generic;
using Corp_Calendar.Models;

namespace Corp_Calendar.Services
{
    public static class CalendarDemoData
    {
        public static List<CalendarEvent> Events { get; private set; }
        public static List<Employee> Employees { get; private set; }
        public static List<EmployeeGroup> EmployeeGroups { get; private set; }

        public static void Init()
        {
            var itGroup = new EmployeeGroup(Guid.NewGuid(), "IT Отдел", new Employee[0]);
            var managers = new EmployeeGroup(Guid.NewGuid(), "Менеджеры", new Employee[0]);

            EmployeeGroups = new List<EmployeeGroup>
            {
                itGroup,
                managers
            };


            Employees = new List<Employee>
            {
                new Employee(Guid.NewGuid(), "Анастасия", "Петрова",  new EmployeeGroup[]{itGroup}),
                new Employee(Guid.NewGuid(), "Екатерина", "Иванова", new EmployeeGroup[]{itGroup}),
                new Employee(Guid.NewGuid(), "Антон", "Сидоров", new EmployeeGroup[]{managers}),
            };

            Events = new List<CalendarEvent>
            {
                new CalendarEvent(Guid.NewGuid(), "Собрание", new Guid[]
                {
                    Employees[0].EmployeeId
                }),
                new CalendarEvent(Guid.NewGuid(), "Выезд" , new Guid[]
                {
                    Employees[1].EmployeeId
                }),
                new CalendarEvent(Guid.NewGuid(), "Обучение", new Guid[]
                {
                    Employees[2].EmployeeId
                }),
                new CalendarEvent(Guid.NewGuid(), "Собрание IT Отдела", new Guid[]
                {
                    itGroup.GroupId
                }),
                new CalendarEvent(Guid.NewGuid(), "Тим билдинг для менеджеров" , new Guid[]
                {
                    managers.GroupId
                }),
            };

            itGroup.Employees = new Employee[]
            {
                Employees[0], Employees[2]
            };

            managers.Employees = new Employee[]
            {
                Employees[2]
            };
    }
    }
}
