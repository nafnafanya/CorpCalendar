using System;
using System.Windows.Forms;
using Corp_Calendar.Models;

namespace Corp_Calendar
{
    public partial class TimeSlotControl : UserControl
    {
        private readonly TimeSlot _slot;
        public event EventHandler<TimeSlot> TimeSelected;
        public event EventHandler<TimeSlot> DateSelected;

        public TimeSlotControl(TimeSlot slot)
        {
            _slot = slot;
            InitializeComponent();
            buttonDate.Text = slot.DateFrom.ToShortDateString();
            buttonTimePeriod.Text = slot.DateFrom.ToShortTimeString() + " - " + slot.DateTo.ToShortTimeString();
        }

        private void buttonTimePeriod_Click(object sender, System.EventArgs e)
        {
            OnTimeSlotSelected(_slot);
        }

        private void buttonDate_Click(object sender, System.EventArgs e)
        {
            OnDateSelected(_slot);
        }

        protected virtual void OnTimeSlotSelected(TimeSlot e)
        {
            TimeSelected?.Invoke(this, e);
        }

        protected virtual void OnDateSelected(TimeSlot e)
        {
            DateSelected?.Invoke(this, e);
        }
    }
}
