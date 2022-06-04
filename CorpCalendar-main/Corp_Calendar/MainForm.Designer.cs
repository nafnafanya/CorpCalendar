
namespace Corp_Calendar
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CalendarPanel = new System.Windows.Forms.TabControl();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageDay = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCalendars = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviosPage = new System.Windows.Forms.Button();
            this.labelSchedulePageInfo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CalendarPanel.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelCalendars.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1379, -46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сменить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_login_Click);
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarPanel.Controls.Add(this.tabPageSchedule);
            this.CalendarPanel.Controls.Add(this.tabPageDay);
            this.CalendarPanel.Controls.Add(this.tabPage3);
            this.CalendarPanel.Controls.Add(this.tabPage4);
            this.CalendarPanel.ItemSize = new System.Drawing.Size(200, 35);
            this.CalendarPanel.Location = new System.Drawing.Point(199, 53);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.SelectedIndex = 0;
            this.CalendarPanel.Size = new System.Drawing.Size(850, 585);
            this.CalendarPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CalendarPanel.TabIndex = 2;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.flowLayoutPanelSchedule);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 39);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(842, 542);
            this.tabPageSchedule.TabIndex = 0;
            this.tabPageSchedule.Text = "РАССПИСАНИЕ";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSchedule
            // 
            this.flowLayoutPanelSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSchedule.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSchedule.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelSchedule.Name = "flowLayoutPanelSchedule";
            this.flowLayoutPanelSchedule.Size = new System.Drawing.Size(836, 536);
            this.flowLayoutPanelSchedule.TabIndex = 0;
            // 
            // tabPageDay
            // 
            this.tabPageDay.Location = new System.Drawing.Point(4, 39);
            this.tabPageDay.Name = "tabPageDay";
            this.tabPageDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDay.Size = new System.Drawing.Size(842, 542);
            this.tabPageDay.TabIndex = 1;
            this.tabPageDay.Text = "ДЕНЬ";
            this.tabPageDay.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(842, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "НЕДЕЛЯ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(842, 542);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "МЕСЯЦ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlPanel.Controls.Add(this.panel2);
            this.ControlPanel.Controls.Add(this.panel1);
            this.ControlPanel.Controls.Add(this.button2);
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(193, 638);
            this.ControlPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUserInfo);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 120);
            this.panel2.TabIndex = 4;
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserInfo.ForeColor = System.Drawing.Color.White;
            this.labelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(193, 72);
            this.labelUserInfo.TabIndex = 2;
            this.labelUserInfo.Text = "Анастасия";
            this.labelUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flowLayoutPanelCalendars);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 460);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сотрудники и группы";
            // 
            // flowLayoutPanelCalendars
            // 
            this.flowLayoutPanelCalendars.Controls.Add(this.checkBox1);
            this.flowLayoutPanelCalendars.Controls.Add(this.checkBox2);
            this.flowLayoutPanelCalendars.Controls.Add(this.checkBox3);
            this.flowLayoutPanelCalendars.Controls.Add(this.checkBox5);
            this.flowLayoutPanelCalendars.Controls.Add(this.checkBox6);
            this.flowLayoutPanelCalendars.Controls.Add(this.checkBox4);
            this.flowLayoutPanelCalendars.Location = new System.Drawing.Point(12, 56);
            this.flowLayoutPanelCalendars.Name = "flowLayoutPanelCalendars";
            this.flowLayoutPanelCalendars.Size = new System.Drawing.Size(171, 365);
            this.flowLayoutPanelCalendars.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Анастасия";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Екатерина";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(91, 28);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 19);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Антон";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 19);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "IT Отдел";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(80, 53);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(87, 19);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "Бухгатерия";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(3, 78);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Менеджеры";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Все календари";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Создать мероприятие";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(441, 11);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(98, 36);
            this.buttonNextPage.TabIndex = 0;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            // 
            // buttonPreviosPage
            // 
            this.buttonPreviosPage.Location = new System.Drawing.Point(199, 11);
            this.buttonPreviosPage.Name = "buttonPreviosPage";
            this.buttonPreviosPage.Size = new System.Drawing.Size(98, 36);
            this.buttonPreviosPage.TabIndex = 0;
            this.buttonPreviosPage.Text = "<";
            this.buttonPreviosPage.UseVisualStyleBackColor = true;
            // 
            // labelSchedulePageInfo
            // 
            this.labelSchedulePageInfo.AutoSize = true;
            this.labelSchedulePageInfo.Location = new System.Drawing.Point(307, 23);
            this.labelSchedulePageInfo.Name = "labelSchedulePageInfo";
            this.labelSchedulePageInfo.Size = new System.Drawing.Size(120, 15);
            this.labelSchedulePageInfo.TabIndex = 1;
            this.labelSchedulePageInfo.Text = "Май 2022 - Май 2022";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1049, 638);
            this.Controls.Add(this.labelSchedulePageInfo);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.buttonPreviosPage);
            this.Controls.Add(this.ControlPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CalendarPanel.ResumeLayout(false);
            this.tabPageSchedule.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelCalendars.ResumeLayout(false);
            this.flowLayoutPanelCalendars.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl CalendarPanel;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.TabPage tabPageDay;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonPreviosPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Label labelSchedulePageInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCalendars;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSchedule;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

