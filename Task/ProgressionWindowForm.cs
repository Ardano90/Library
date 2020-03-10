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

        private bool cancelled = false;

        private bool estimateDuration;

        private bool subtaskControlsVisible;

        public ProgressionWindowForm(bool estimate, bool subtask)
        {
            subtaskControlsVisible = subtask;
            estimateDuration = estimate;

            InitializeComponent();
            StartTime = DateTime.Now;

        }


        public bool Cancelled
        {
            get
            {
                return cancelled;
            }

        }

        private void updateEstimatedTime()
        {

        }

        private void ProgressionbarForm_Load(object sender, EventArgs e)
        {

            labelEstimatedTime.Visible = estimateDuration;

            labelProgressSubtask.Visible = subtaskControlsVisible;
            progressBarSubtask.Visible = subtaskControlsVisible;
        }

        public void UpdateControls(TaskProgress prog)
        {
            ProgressBar.Value = prog.PercentageDone;
            labelProgress.Update();

            progressBarSubtask.Value = prog.PercentageDoneSubtask;
            labelProgressSubtask.Update();

            labelEstimatedTime.Text = prog.LabelEstimatedDuration;
            labelProgress.Update();

            labelProgressSubtask.Text = prog.PercentageDoneSubtask.ToString() + "%";
            labelProgressSubtask.Update();

            labelProgress.Text = prog.PercentageDone.ToString() + "%";
            labelProgress.Update();

            labelTaskSheet.Text = prog.LabelTask;
            labelTaskSheet.Update();

            labelTaskView.Text = prog.LabelSubtask;
            labelTaskView.Update();

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            labelEstimatedTime.Text = "";
            labelEstimatedTime.Update();

            labelTaskSheet.Text = "Cancelling task...";
            labelTaskSheet.Update();

            labelTaskView.Text = "";
            labelTaskView.Update();

            cancelled = true;
        }
    }
}


