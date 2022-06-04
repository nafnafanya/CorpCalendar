using System.Windows.Forms;
using Corp_Calendar.Models;
using Corp_Calendar.Services;

namespace Corp_Calendar
{
    public partial class SchedulePanelEventControl : UserControl
    {
        private CalendarEvent _event;

        public SchedulePanelEventControl(CalendarEvent ev)
        {
            InitializeComponent();
            labelDate.Text = ev.GetDatesInfo();
            labelInfo.Text = ev.Subject;
            _event = ev;

            toolStripMenuItem1.Click += (sender, args) => { EditEvent(); };
            toolStripMenuItem2.Click += (sender, args) => { RemoveEvent(); };
        }

        private void RemoveEvent()
        {
            var res = MessageBox.Show("Удалить мероприятие?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (res == DialogResult.Cancel)
            {
                return;
            }

            ServiceContainer.CalendarEventService.Delete(_event);
        }

        private void editBtn_Click(object sender, System.EventArgs e)
        {
            contextMenuStrip1.Show((Button)sender, 0, 0);
        }

        private void EditEvent()
        {
            var editEventForm = new EditEventForm(_event);
            editEventForm.ShowDialog();
        }
    }
}
