using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;


namespace Ardano.Library
{

    public partial class ProgressionBarForm : System.Windows.Forms.Form
    {

        private DateTime StartTime;

        private delegate void UpdateProgress(int percentage);

        private delegate void UpdateLabel(string label);

        public ProgressionBarForm(EventHandler<TaskProgress> eventHandler)
        {

            eventHandler += Prog_ProgressChanged;

            InitializeComponent();
            StartTime = DateTime.Now;


        }

        private void ProgressionbarForm_Load(object sender, EventArgs e)
        {
            labelProgress.Parent = ProgressBar;
        }

        private void Prog_ProgressChanged(object sender, TaskProgress e)
        {
            if (labelProgress.InvokeRequired)
            {
                UpdateProgress d = new UpdateProgress(ChangelabelProgress);
                labelProgress.Invoke(d, e.PercentageDone);
            }

            else
            {
                ChangelabelProgress(e.PercentageDone);
            }


            if (ProgressBar.InvokeRequired)
            {
                UpdateProgress d = new UpdateProgress(ChangeProgressBar);
                ProgressBar.Invoke(d, e.PercentageDone);
            }

            else
            {
                ChangeProgressBar(e.PercentageDone);
            }

            if (labelTaskSheet.InvokeRequired)
            {
                UpdateLabel d = new UpdateLabel(ChangelabelTaskSheet);
                labelTaskSheet.Invoke(d, e.Label1);
            }

            else
            {
                ChangelabelTaskSheet(e.Label1);
            }

            if (labelTaskView.InvokeRequired)
            {
                UpdateLabel d = new UpdateLabel(ChangelabelTaskView);
                labelTaskView.Invoke(d, e.Label2);
            }

            else
            {
                ChangelabelTaskView(e.Label2);
            }

        }

        private void ChangeProgressBar(int percentage)
        {
            ProgressBar.Value = percentage;
            ProgressBar.Update();
        }



        private void ChangelabelProgress(int percentage)
        {
            labelProgress.Text = percentage.ToString() + "%";
            labelProgress.Update();
        }


        private void ChangelabelTaskSheet(string label)
        {
            labelTaskSheet.Text = label;
            labelTaskSheet.Update();
        }


        private void ChangelabelTaskView(string label)
        {
            labelTaskSheet.Text = label;
            labelTaskSheet.Update();
        }



        private void ChangeEstimatedDuration(double percentage)
        {
            if (percentage > 0)
            {
                TimeSpan timeSpent = TimeSpan.FromTicks(DateTime.Now.Subtract(StartTime).Ticks);
                TimeSpan estimatedTime = TimeSpan.FromMilliseconds((timeSpent.TotalMilliseconds / percentage) * (100 - percentage));
                string estimatedTimeString = string.Format("{0:D2}m:{1:D2}s",
                    estimatedTime.Minutes,
                    estimatedTime.Seconds);
                labelEstimatedTime.Text = estimatedTimeString;
                labelEstimatedTime.Update();
            }

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            RevitTask.Cancelled = true;
        }
    }
}


