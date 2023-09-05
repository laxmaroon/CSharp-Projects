namespace Alarm_Clock__AEC_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.alarmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.currentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(357, 82);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(44, 16);
            this.currentTimeLabel.TabIndex = 0;
            this.currentTimeLabel.Text = "label1";
            // 
            // alarmTimePicker
            // 
            this.alarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarmTimePicker.Location = new System.Drawing.Point(300, 143);
            this.alarmTimePicker.Name = "alarmTimePicker";
            this.alarmTimePicker.Size = new System.Drawing.Size(200, 22);
            this.alarmTimePicker.TabIndex = 1;
            this.alarmTimePicker.ValueChanged += new System.EventHandler(this.alarmTime_ValueChanged);
            // 
            // currentTimePicker
            // 
            this.currentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.currentTimePicker.Location = new System.Drawing.Point(300, 214);
            this.currentTimePicker.Name = "currentTimePicker";
            this.currentTimePicker.Size = new System.Drawing.Size(200, 22);
            this.currentTimePicker.TabIndex = 2;
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Location = new System.Drawing.Point(360, 303);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.setAlarmButton.TabIndex = 3;
            this.setAlarmButton.Text = "button1";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.currentTimePicker);
            this.Controls.Add(this.alarmTimePicker);
            this.Controls.Add(this.currentTimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.DateTimePicker alarmTimePicker;
        private System.Windows.Forms.DateTimePicker currentTimePicker;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Timer timer;
    }
}

