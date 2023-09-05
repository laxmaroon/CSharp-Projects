using System;
using System.Threading;
using System.Windows.Forms;
namespace Thread
{
    public partial class Form1 : Form
    {
        private System.Threading.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
        }
        private void TimerCallback(object state)
        {
            // Update the time on a separate thread
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            UpdateTimeLabel(currentTime);
        }
        private void UpdateTimeLabel(string time)
        {
            // Update the time label using Control.Invoke to marshal the update to the UI thread
            if (lblTime.InvokeRequired)
            {
                lblTime.Invoke(new Action<string>(UpdateTimeLabel), time);
            }
            else
            {
                lblTime.Text = time;
            }
        }
    }
}