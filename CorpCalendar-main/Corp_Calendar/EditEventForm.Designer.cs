
namespace Corp_Calendar
{
    partial class EditEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.l2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.intentText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.placeText = new System.Windows.Forms.RichTextBox();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.membersLbx = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(524, 450);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(247, 39);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цель:";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(79, 12);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 23);
            this.dateFrom.TabIndex = 3;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(355, 10);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 23);
            this.dateTo.TabIndex = 4;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(24, 18);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(49, 15);
            this.l2.TabIndex = 2;
            this.l2.Text = "Начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Конец";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Участники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Комментарии:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(102, 348);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(368, 138);
            this.DescriptionText.TabIndex = 7;
            this.DescriptionText.Text = "";
            // 
            // intentText
            // 
            this.intentText.Location = new System.Drawing.Point(102, 204);
            this.intentText.Name = "intentText";
            this.intentText.Size = new System.Drawing.Size(368, 138);
            this.intentText.TabIndex = 7;
            this.intentText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тема";
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(102, 86);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(368, 36);
            this.subjectText.TabIndex = 7;
            this.subjectText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Место";
            // 
            // placeText
            // 
            this.placeText.Location = new System.Drawing.Point(102, 140);
            this.placeText.Name = "placeText";
            this.placeText.Size = new System.Drawing.Size(368, 36);
            this.placeText.TabIndex = 7;
            this.placeText.Text = "";
            // 
            // timeFrom
            // 
            this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFrom.Location = new System.Drawing.Point(79, 41);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.ShowUpDown = true;
            this.timeFrom.Size = new System.Drawing.Size(200, 23);
            this.timeFrom.TabIndex = 3;
            // 
            // timeTo
            // 
            this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeTo.Location = new System.Drawing.Point(355, 39);
            this.timeTo.Name = "timeTo";
            this.timeTo.ShowUpDown = true;
            this.timeTo.Size = new System.Drawing.Size(200, 23);
            this.timeTo.TabIndex = 3;
            // 
            // membersLbx
            // 
            this.membersLbx.FormattingEnabled = true;
            this.membersLbx.Location = new System.Drawing.Point(496, 114);
            this.membersLbx.Name = "membersLbx";
            this.membersLbx.Size = new System.Drawing.Size(275, 328);
            this.membersLbx.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Найти свободное время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 536);
            this.Controls.Add(this.membersLbx);
            this.Controls.Add(this.placeText);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.intentText);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.timeTo);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveBtn);
            this.Name = "EditEventForm";
            this.Text = "Редактор мероприятия";
            this.Load += new System.EventHandler(this.EditEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.RichTextBox intentText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox subjectText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox placeText;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.CheckedListBox membersLbx;
        private System.Windows.Forms.Button button1;
    }
}