using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace Ardano.Library
{
    public class ProgressionWindow
    {

        private DateTime StartTime;


        private Dispatcher UIDispatcher;

        private ProgressionWindowForm progBarForm;

        private event EventHandler<TaskProgress> ProgressChangedEvent;


        public ProgressionWindow()

        {
            Dispatcher currentDispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher;

            Thread t = new Thread(startThread);
            t.Start();
        }



        private void Prog_ProgressChanged(object sender, TaskProgress e)
        {
            progBarForm.ChangeLabels(e);

        }

        public TaskProgress Progress { get; set; } = new TaskProgress();


        public void UpdateProgress()
        {

            UIDispatcher.Invoke(new Action(() => {
                if (ProgressChangedEvent != null)
                    ProgressChangedEvent(this, Progress);
            }));

        }

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

            using (ProgressionWindowForm pgbr = new ProgressionWindowForm())
            {
                pgbr.Show();
                pgbr.BringToFront();
                pgbr.Focus();
                progBarForm = pgbr;

                ProgressChangedEvent += Prog_ProgressChanged;

                System.Windows.Threading.Dispatcher.Run();
            }

        }

        public void Close()
        {
            UIDispatcher.Invoke(new Action(() => {
                UIDispatcher.Thread.Abort(); ;
            }));
        }


    }
}
