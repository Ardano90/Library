using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ardano.Library
{
    public class RevitTask

    {

        private event EventHandler<TaskProgress> ProgressChanged;

        public static Boolean Cancelled { get; set; }

        public TaskProgress Progress { get; set; } = new TaskProgress();


        public void UpdateProgress()
        {
            ProgressChanged?.Invoke(this, Progress);
        }


        private void startThread(object eventHandler)
        {
            var handler = (EventHandler<TaskProgress>)eventHandler;
            using (ProgressionBarForm pgbr = new ProgressionBarForm(handler))
            {
                pgbr.Show();
                pgbr.Focus();

                System.Windows.Threading.Dispatcher.Run();
            }

        }


        public void ShowWindow()
        {
            Thread t = new Thread(new ParameterizedThreadStart(startThread));
            t.Start(ProgressChanged);
        }

    }
}
