using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Corp_Calendar.Models;
using Corp_Calendar.Services;

namespace Corp_Calendar
{
    public partial class EditEventForm : Form
    {
        private CalendarEvent _calendarEvent;

        public EditEventForm(CalendarEvent calendarEvent)
        {
            _calendarEvent = calendarEvent;
            InitializeComponent();
        }

        public CalendarInfo[] Members { get; set; }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_calendarEvent == null)
                {
                    _calendarEvent = new CalendarEvent(Guid.NewGuid());
                }

                var members = GetMembersIds();

                _calendarEvent.Intent = intentText.Text;
                _calendarEvent.Subject = subjectText.Text;
                _calendarEvent.Description = DescriptionText.Text;
                _calendarEvent.Place = placeText.Text;
                _calendarEvent.DateFrom = dateFrom.Value;
                _calendarEvent.DateTo = dateTo.Value;
                _calendarEvent.Members = members.ToArray();

                ServiceContainer.CalendarEventService.CreateOrUpdate(_calendarEvent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
                return;
            }
            MessageBox.Show("Сохранено");
            Close();
        }

        private List<Guid> GetMembersIds()
        {
            var members = new List<Guid>();

            for (var i = 0; i < membersLbx.Items.Count; i++)
            {
                if (membersLbx.GetItemChecked(i))
                {
                    members.Add((membersLbx.Items[i] as CalendarInfo).CalendarId);
                }
            }

            return members;
        }

        private List<CalendarInfo> GetMembers()
        {
            var members = new List<CalendarInfo>();

            for (var i = 0; i < membersLbx.Items.Count; i++)
            {
                if (membersLbx.GetItemChecked(i))
                {
                    members.Add((membersLbx.Items[i] as CalendarInfo));
                }
            }

            return members;
        }

        private void EditEventForm_Load(object sender, System.EventArgs e)
        {
            Members = ServiceContainer.EmployeeService.GetEmployeesAndGroupCalendars();

            membersLbx.DataSource = Members;
            membersLbx.DisplayMember = "Name";

            if (_calendarEvent != null)
            {
                for (var i = 0; i < membersLbx.Items.Count; i++)
                {
                    foreach (var evMemberId in _calendarEvent.Members)
                    {
                        if (evMemberId == (membersLbx.Items[i] as CalendarInfo).CalendarId)
                        {
                            membersLbx.SetItemChecked(i, true);
                            break;
                        }
                    }
                }

                intentText.Text = _calendarEvent.Intent;
                subjectText.Text = _calendarEvent.Subject;
                DescriptionText.Text = _calendarEvent.Description;
                placeText.Text = _calendarEvent.Place;
                dateFrom.Value = _calendarEvent.DateFrom;
                dateTo.Value = _calendarEvent.DateTo;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchTimeForm = new AvailableTimeSearchForm(GetMembers());
            searchTimeForm.Closed += SearchTimeFormOnClosed;
            searchTimeForm.Show();
        }

        private void SearchTimeFormOnClosed(object? sender, EventArgs e)
        {
            var dateFrom = (sender as AvailableTimeSearchForm).DateFromSearch;
            var dateTo = (sender as AvailableTimeSearchForm).DateToSearch;

            this.dateFrom.Value = dateFrom;
            this.timeTo.Value = dateFrom;
            this.dateTo.Value = dateTo;
            this.timeTo.Value = dateTo;
        }
    }
}
