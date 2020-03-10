using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Forms;

namespace Ardano.Library
{
    public class ProgressionWindow
    {
        private Dispatcher UIDispatcher;

        private ProgressionWindowForm progBarForm;

        private event EventHandler<TaskProgress> ProgressChangedEvent;

        private bool estimate = false;

        private bool subtask = false;

        private DateTime StartTime;


        public TaskProgress Progress { get; set; } = new TaskProgress();

        /// <summary>
        /// Creates a window in a new thread, wich shows the progression of a task
        /// </summary>
        /// <param name="estimateTime"></param>
        /// <param name="ProgressSubtask"></param>

        public ProgressionWindow(bool EstimateTime, bool SubtaskProgress)

        {
            estimate = EstimateTime;
            subtask = SubtaskProgress;

            StartTime = DateTime.Now;


            Thread t = new Thread(startThread);
            t.Start();

        }


        private void Prog_ProgressChanged(object sender, TaskProgress e)
        {

            if (estimate == true)
            {
                if (e.PercentageDone > 0)
                {
                    TimeSpan timeSpent = TimeSpan.FromTicks(DateTime.Now.Subtract(StartTime).Ticks);
                    TimeSpan estimatedTime = TimeSpan.FromMilliseconds((timeSpent.TotalMilliseconds / e.PercentageDone) * (100 - e.PercentageDone));
                    string estimatedTimeString = string.Format("{0:D2}m:{1:D2}s",
                        estimatedTime.Minutes,
                        estimatedTime.Seconds);
                    e.LabelEstimatedDuration = estimatedTimeString;
                }
            }

            progBarForm.UpdateControls(e);

        }


        public void UpdateProgress()
        {

            UIDispatcher.Invoke(new Action(() => {
                if (ProgressChangedEvent != null)
                    ProgressChangedEvent(this, Progress);
            }));

        }

        /// <summary>
        /// check this property periodically to cancel your task at the right moment
        /// </summary>

        public Boolean Cancelled
        {
            get
            {
                return progBarForm.Cancelled;

            }
        }


        private void startThread()
        {
            Dispatcher currentDispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher;
            UIDispatcher = currentDispatcher;

            using (ProgressionWindowForm pgbr = new ProgressionWindowForm(estimate, subtask))
            {
                progBarForm = pgbr;
                ProgressChangedEvent += Prog_ProgressChanged;
                pgbr.BringToFront();
                pgbr.Focus();



                System.Windows.Forms.Application.Run(pgbr);

            }

        }


        public void Close()
        {
            UIDispatcher.Invoke(new Action(() => {

                System.Windows.Forms.Application.Exit();
            }));
        }

    }
}
