namespace Meeting
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.btnScheduleMeeting = new System.Windows.Forms.Button();
            this.listViewMeetings = new System.Windows.Forms.ListView();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(77, 106);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(421, 78);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // btnScheduleMeeting
            // 
            this.btnScheduleMeeting.Location = new System.Drawing.Point(425, 213);
            this.btnScheduleMeeting.Name = "btnScheduleMeeting";
            this.btnScheduleMeeting.Size = new System.Drawing.Size(94, 29);
            this.btnScheduleMeeting.TabIndex = 2;
            this.btnScheduleMeeting.Text = "Schedule";
            this.btnScheduleMeeting.UseVisualStyleBackColor = true;
            this.btnScheduleMeeting.Click += new System.EventHandler(this.btnScheduleMeeting_Click_1);
            // 
            // listViewMeetings
            // 
            this.listViewMeetings.Location = new System.Drawing.Point(428, 309);
            this.listViewMeetings.Name = "listViewMeetings";
            this.listViewMeetings.Size = new System.Drawing.Size(151, 121);
            this.listViewMeetings.TabIndex = 3;
            this.listViewMeetings.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(421, 153);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerEnd.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.listViewMeetings);
            this.Controls.Add(this.btnScheduleMeeting);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePickerStart;
        private Button btnScheduleMeeting;
        private ListView listViewMeetings;
        private DateTimePicker dateTimePickerEnd;
    }
}