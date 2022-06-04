using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Corp_Calendar.Models;
using Corp_Calendar.Services;

namespace Corp_Calendar
{
    public partial class AvailableTimeSearchForm : Form
    {
        private readonly List<CalendarInfo> _members = new List<CalendarInfo>();

        public AvailableTimeSearchForm(List<CalendarInfo> members)
        {
            _members = members;
            InitializeComponent();
        }

        public DateTime DateFromSearch => DateTimeHelper.GeDateTime(dateFrom.Value, timeFrom.Value);
        public DateTime DateToSearch => DateTimeHelper.GeDateTime(dateTo.Value, timeTo.Value);

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var slots = ServiceContainer.CalendarEventService.SearchAvailableTime(DateFromSearch, DateToSearch, _members);

            flowLayoutPanel1.Controls.Clear();

            foreach (var slot in slots)
            {
                var slotControl = new TimeSlotControl(slot);

                slotControl.DateSelected += (o, timeSlot) =>
                {
                    dateFrom.Value = timeSlot.DateFrom;
                    timeFrom.Value = DateTime.Today;
                    dateTo.Value = timeSlot.DateFrom.Date;
                    timeTo.Value = DateTime.Today.AddHours(24).AddMilliseconds(-1);
                };

                slotControl.TimeSelected += (o, timeSlot) =>
                {
                    dateFrom.Value = timeSlot.DateFrom;
                    timeFrom.Value = timeSlot.DateFrom;
                    dateTo.Value = timeSlot.DateFrom;
                    timeTo.Value = timeSlot.DateFrom;
                    Close();
                };

                flowLayoutPanel1.Controls.Add(slotControl);
            }

        }
    }
}
