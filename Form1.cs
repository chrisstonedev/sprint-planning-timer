using SprintPlanningTimer.Properties;
using System;
using System.Drawing;
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
            dueTime.Value = DateTime.Now.AddHours(1);
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan getTimeRemaining(TimeSpan difference) => difference >= TimeSpan.Zero ? difference.Add(new TimeSpan(0, 0, 1)) : difference;
            string getTimeFormatString(TimeSpan timeRemaining) => ((int)timeRemaining.TotalSeconds < 0 ? "-" : string.Empty) + timeRemaining.ToString(@"h\:mm\:ss");
            Color getTimeDisplayColor(TimeSpan timeRemaining) => (int)timeRemaining.TotalSeconds < 0 ? Color.Red : Color.Black;

            var totalTimeRemaining = getTimeRemaining(countdownTotal.TimeOfDay - DateTime.Now.TimeOfDay);
            totalTime.Text = getTimeFormatString(totalTimeRemaining);
            totalTime.ForeColor = getTimeDisplayColor(totalTimeRemaining);

            var itemTimeRemaining = getTimeRemaining(countdownTime - DateTime.Now);
            itemTime.Text = getTimeFormatString(itemTimeRemaining);
            itemTime.ForeColor = getTimeDisplayColor(itemTimeRemaining);
        }

        private void OneDownButton_Click(object sender, EventArgs e)
        {
            openItemCount.Value -= 1;
            ResetValues();
            if (openItemCount.Value == 0)
                StartOverButton_Click(sender, e);
        }

        private void ResetItemButton_Click(object sender, EventArgs e)
        {
            ResetValues();
            oneDownButton.Enabled = true;
            timer.Enabled = true;
        }

        private void StartOverButton_Click(object sender, EventArgs e)
        {
            bool isStopping = startOverButton.Text == Resources.StartOverButton;
            if (!isStopping)
                ResetValues();

            if (openItemCount.Value == 0)
                return;

            totalTime.Enabled = itemTime.Enabled = oneDownButton.Enabled = resetItemButton.Enabled = timer.Enabled = !isStopping;
            openItemCount.Enabled = dueTime.Enabled = isStopping;
            startOverButton.Text = isStopping ? Resources.StartButton : Resources.StartOverButton;
        }
    }
}