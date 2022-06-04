using System;
using System.Windows.Forms;
using Corp_Calendar.Models;
using Corp_Calendar.Services;

namespace Corp_Calendar
{
    public partial class LoginForm : Form
    {
        public LoginForm(Employee[] users)
        {
            InitializeComponent();

            if (users != null)
            {
                flowLayoutPanel1.Controls.Clear();
                
                foreach (var user in users)
                {
                    var userButton = new Button();
                    userButton.Height = 50;
                    userButton.Width = 100;
                    userButton.Text = user.FullName;
                    userButton.Tag = user;
                    userButton.Click += UserButtonOnClick;
                    flowLayoutPanel1.Controls.Add(userButton);
                }
            }
        }

        private void UserButtonOnClick(object sender, EventArgs e)
        {
            var button = (Button) sender;
            var user = (Employee) button.Tag;
            ServiceContainer.EmployeeController.Login(user.EmployeeId);
            this.Close();
        }
    }
}
