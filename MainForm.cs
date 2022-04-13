using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorpCalendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm newForm = new EmployeeInfoForm();
            newForm.textBox1.Text = this.button1.Text;
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm newForm = new EmployeeInfoForm();
            newForm.textBox1.Text = this.button2.Text;
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm newForm = new EmployeeInfoForm();
            newForm.textBox1.Text = this.button3.Text;
            newForm.Show();
        }
    }
}
