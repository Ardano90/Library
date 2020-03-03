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

    public partial class ProgressionWindowForm : System.Windows.Forms.Form
    {
        private DateTime StartTime;

        public Boolean Cancelled = false;

        public ProgressionWindowForm()
        {

            InitializeComponent();
            StartTime = DateTime.Now;


        }

        private void ProgressionbarForm_Load(object sender, EventArgs e)
        {
            labelProgress.Parent = ProgressBar;
        }


        public void ChangeLabels(TaskProgress prog)
        {
            ProgressBar.Refresh();
            ProgressBar.Value = prog.PercentageDone;

            labelProgress.Text = prog.PercentageDone.ToString() + "%";
            labelProgress.Update();

            labelTaskSheet.Text = prog.Label1;
            labelTaskSheet.Update();

            labelTaskView.Text = prog.Label2;
            labelTaskView.Update();

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
            Cancelled = true;
        }
    }
}


