
namespace Corp_Calendar
{
    partial class TimeSlotControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDate = new System.Windows.Forms.Button();
            this.buttonTimePeriod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(3, 4);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(145, 37);
            this.buttonDate.TabIndex = 0;
            this.buttonDate.Text = "22 мая 2022";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonTimePeriod
            // 
            this.buttonTimePeriod.Location = new System.Drawing.Point(154, 4);
            this.buttonTimePeriod.Name = "buttonTimePeriod";
            this.buttonTimePeriod.Size = new System.Drawing.Size(145, 37);
            this.buttonTimePeriod.TabIndex = 0;
            this.buttonTimePeriod.Text = "13:00 - 14:00";
            this.buttonTimePeriod.UseVisualStyleBackColor = true;
            this.buttonTimePeriod.Click += new System.EventHandler(this.buttonTimePeriod_Click);
            // 
            // TimeSlotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.buttonTimePeriod);
            this.Controls.Add(this.buttonDate);
            this.Name = "TimeSlotControl";
            this.Size = new System.Drawing.Size(305, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.Button buttonTimePeriod;
    }
}
