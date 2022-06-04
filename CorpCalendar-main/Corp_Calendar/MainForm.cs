using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Corp_Calendar.Models;
using Corp_Calendar.Services;

namespace Corp_Calendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += LoadEvent;

            flowLayoutPanelSchedule.FlowDirection = FlowDirection.TopDown;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
       
        private void LoadEvent(object sender, EventArgs e)
        {
            // Demo data
            CalendarDemoData.Init();

            // Init all services
            ServiceContainer.Init();
            // Run login form
            Login();
        }

        private void Login()
        {
            var users = ServiceContainer.EmployeeService.GetEmployees();

            LoginForm loginform = new LoginForm(users);

            loginform.FormClosed += LoginformOnFormClosed;
            loginform.Owner = this;
            loginform.Show();
        }

        private void LoginformOnFormClosed(object sender, FormClosedEventArgs e)
        {
            ((LoginForm)sender).FormClosed -= LoginformOnFormClosed;
            UpdateUserInfo();
        }

        private void UserCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            FilterCalendars();
        }

        private void FilterCalendars()
        {
            var filteredCalendars = new List<CalendarInfo>();
            var filteredEvents = new List<CalendarEvent>();

            foreach (Control control in flowLayoutPanelCalendars.Controls)
            {
                var checkBox = (CheckBox)control;
                var calendarInfo = (CalendarInfo)checkBox.Tag;

                if (checkBox.Checked)
                {
                    filteredCalendars.Add(calendarInfo);
                }
            }

            var calendarEvents = ServiceContainer.CalendarEventService.GetCalendarEvents(filteredCalendars);
            filteredEvents.AddRange(calendarEvents);

            if (CalendarPanel.SelectedTab == tabPageSchedule)
            {
                // TODO Сортировка по дате

                flowLayoutPanelSchedule.Controls.Clear();

                foreach (var ev in filteredEvents)
                {
                    SchedulePanelEventControl calendarEvent = new SchedulePanelEventControl(ev);

                    flowLayoutPanelSchedule.Controls.Add(calendarEvent);
                }
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void UpdateUserInfo()
        {
            labelUserInfo.Text = ServiceContainer.EmployeeController.CurrentEmployee.FullName + "\n(" + ServiceContainer.EmployeeController.CurrentEmployee.GoupNames + ")";

            flowLayoutPanelCalendars.Controls.Clear();

            var calendars = ServiceContainer.EmployeeService.GetEmployeesAndGroupCalendars();
            
            foreach (var calendarInfo in calendars)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = calendarInfo.Name;
                checkBox.Tag = calendarInfo;
                checkBox.CheckedChanged += UserCheckBoxOnCheckedChanged;
                flowLayoutPanelCalendars.Controls.Add(checkBox);

                if (ServiceContainer.EmployeeController.CurrentEmployee.EmployeeId == calendarInfo.CalendarId)
                {
                    checkBox.Checked = true;
                }

                foreach (var group in ServiceContainer.EmployeeController.CurrentEmployee.Groups)
                {
                    if (group.GroupId == calendarInfo.CalendarId)
                    {
                        checkBox.Checked = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilterCalendars();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editEventForm = new EditEventForm(null);
            editEventForm.ShowDialog();
        }
    }
}
