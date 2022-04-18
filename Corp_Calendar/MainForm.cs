using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corp_Calendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += LoadEvent;
        }
       

        void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login loginform = (Login)sender;
            this.label1.Text = loginform.selectedEmployee;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
       
        private void LoadEvent(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.FormClosed += new FormClosedEventHandler(Login_FormClosed);
            loginform.Owner = this;
            loginform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            label1.Text = loginform.selectedEmployee;
            label1.Text = null;
            loginform.FormClosed += new FormClosedEventHandler(Login_FormClosed);
            loginform.Show();
        }
    }

}
