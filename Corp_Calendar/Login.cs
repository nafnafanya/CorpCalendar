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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string selectedEmployee;
        private void button1_Click(object sender, EventArgs e)
        {
            selectedEmployee = button1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedEmployee = button2.Text;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedEmployee = button3.Text;
            this.Close();
        }
       
    }
}
