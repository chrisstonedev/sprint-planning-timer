using System;
using System.Windows.Forms;

namespace SprintPlanningTimer
{
    public partial class Form1 : Form
    {
        private DateTime countdownTime;
        private DateTime countdownTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetValues();
            oneDown.Enabled = true;
            timer1.Enabled = true;
        }

        private void OneDown_Click(object sender, EventArgs e)
        {
            openItemCount.Value -= 1;
            ResetValues();
        }

        private void ResetValues()
        {
            if (openItemCount.Value == 0)
            {
                MessageBox.Show("Completed!");
                return;
            }

            DateTime resetTime = DateTime.Now;
            TimeSpan test = dueTime.Value.TimeOfDay - resetTime.TimeOfDay;
            double t2 = test.TotalMilliseconds;
            double t3 = t2 / (int)openItemCount.Value;
            countdownTime = resetTime.AddMilliseconds(t3);
            countdownTotal = dueTime.Value;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var test = countdownTotal.TimeOfDay - DateTime.Now.TimeOfDay;
            totalTime.Text = $"{(int)test.TotalHours}:{test.Minutes:00}:{test.Seconds:00}";
            var test2 = countdownTime - DateTime.Now;
            itemTime.Text = $"{(int)test2.TotalHours}:{test2.Minutes:00}:{test2.Seconds:00}";
        }
    }
}