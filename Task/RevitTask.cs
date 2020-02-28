using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace Ardano.Library
{
    public class RevitTask

    {

        private event EventHandler<TaskProgress> ProgressChanged;

        public static Boolean Cancelled { get; set; }

        public TaskProgress Progress { get; set; } = new TaskProgress();

        private Dispatcher UIDispatcher;


        public void UpdateProgress()
        {
            ProgressChanged?.Invoke(this, Progress);
        }


        private void startThread(object eventHandler)
        {
            Dispatcher currentDispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher;
            UIDispatcher = currentDispatcher;

            currentDispatcher.Invoke(new Action(() => {
                if (ProgressChanged != null)
                    ProgressChanged(this, Progress);
            }));


            using (ProgressionBarForm pgbr = new ProgressionBarForm(ProgressChanged))
            {
                pgbr.Show();
                pgbr.Focus();

                System.Windows.Threading.Dispatcher.Run();
            }

        }

        public void Close()
        {
            UIDispatcher.Invoke(new Action(() => {
                UIDispatcher.Thread.Abort(); ;
            }));
        }


        public void ShowWindow()
        {
            Thread t = new Thread(new ParameterizedThreadStart(startThread));
            t.Start(ProgressChanged);
        }

    }
}
