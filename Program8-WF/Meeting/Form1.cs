using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Meeting
{
    public partial class Form1 : Form
    {
        private List<Meeting> meetings;
        public Form1()
        {
            InitializeComponent();
            meetings = new List<Meeting>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
            btnScheduleMeeting.Click += BtnScheduleMeeting_Click;
        }
        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTimePickerStart.Value = e.Start;
            dateTimePickerEnd.Value = e.Start.AddHours(1);
        }
        private void BtnScheduleMeeting_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;

            // Check for meeting conflicts
            bool hasConflict = false;
            foreach (Meeting meeting in meetings)
            {
                if (start < meeting.End && end > meeting.Start)
                {
                    hasConflict = true;
                    break;
                }
            }

            if (hasConflict)
            {
                MessageBox.Show("There is a scheduling conflict with an existing meeting.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Meeting newMeeting = new Meeting(start, end);
                meetings.Add(newMeeting);

                ListViewItem item = new ListViewItem(new string[]
                {
                    newMeeting.Start.ToString(),
                    newMeeting.End.ToString()
                });

                listViewMeetings.Items.Add(item);

                MessageBox.Show("Meeting scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public class Meeting
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public Meeting(DateTime start, DateTime end)
            {
                Start = start;
                End = end;
            }
        }

        private void btnScheduleMeeting_Click_1(object sender, EventArgs e)
        {
        }
    }

}
