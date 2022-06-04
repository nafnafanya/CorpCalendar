namespace Corp_Calendar.Services
{
    /// <summary>
    ///     All system services container
    /// </summary>
    public static class ServiceContainer
    {
        public static EmployeeService EmployeeService;
        public static EmployeeController EmployeeController;
        public static CalendarEventService CalendarEventService;

        public static void Init()
        {
            EmployeeService = new EmployeeService();
            EmployeeController = new EmployeeController(EmployeeService);
            CalendarEventService = new CalendarEventService();
        }
    }
}
