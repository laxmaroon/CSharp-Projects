using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock__AEC_
{
    public partial class Form1 : Form
    {
        private bool isAlarmSet = false;
        private DateTime alarmTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            currentTimeLabel.Text = currentTime.ToString("hh:mm:ss tt");

            if (isAlarmSet && currentTime.Hour == alarmTimePicker.Value.Hour && currentTime.Minute == alarmTimePicker.Value.Minute && currentTime.Second == alarmTimePicker.Value.Second)
            {
                timer.Stop();
                MessageBox.Show("Wake up! It's time for the alarm!");

                // Reset the alarm
                isAlarmSet = false;
                setAlarmButton.Text = "Set Alarm";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isAlarmSet)
            {
                alarmTime = alarmTimePicker.Value;
                isAlarmSet = true;
                setAlarmButton.Text = "Cancel Alarm";
            }
            else
            {
                isAlarmSet = false;
                setAlarmButton.Text = "Set Alarm";
            }
        }

        private void alarmTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

