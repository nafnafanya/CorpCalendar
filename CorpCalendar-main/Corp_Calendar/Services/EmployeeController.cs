using System;
using Corp_Calendar.Models;

namespace Corp_Calendar.Services
{
    /// <summary>
    ///  Logic of system users 
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public Employee CurrentEmployee { get; private set; }

        public void Login(Guid id)
        {
            CurrentEmployee = _employeeService.GetEmployeeById(id);
        }

        public void Logout()
        {
            CurrentEmployee = null;
        }
    }
}
