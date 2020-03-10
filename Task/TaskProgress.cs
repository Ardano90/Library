using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ardano.Library
{
    public class TaskProgress

    {

        private int percentageDone = 0;
        private object percentageDoneLock = new object();

        private int percentageDoneSubtask = 0;
        private object percentageDoneSubtaskLock = new object();

        private string labelEstimatedDuration;
        private object labelEstimateDurationLock = new object();

        private string labelTask = "";
        private object labelTaskLock = new object();

        private string labelSubtask = "";
        private object labelSubtaskLock = new object();

        public string LabelSubtask
        {
            get
            {
                lock (labelSubtaskLock)
                {
                    return labelSubtask;
                }
            }

            set
            {
                lock (labelSubtaskLock)
                {
                    labelSubtask = value;
                }
            }
        }


        public string LabelTask
        {
            get
            {
                lock (labelTaskLock)
                {
                    return labelTask;
                }

            }


            set
            {
                lock (labelTaskLock)
                {
                    labelTask = value;

                }
            }
        }


        public string LabelEstimatedDuration
        {
            get
            {
                lock (labelEstimateDurationLock)
                {
                    return labelEstimatedDuration;
                }

            }


            set
            {
                lock (labelEstimateDurationLock)
                {
                    labelEstimatedDuration = value;

                }
            }
        }



        public int PercentageDone
        {
            get
            {
                lock (percentageDoneLock)
                {
                    return percentageDone;
                }
            }

            set
            {
                lock (percentageDoneLock)
                {
                    percentageDone = value;
                }
            }
        }

        public int PercentageDoneSubtask
        {
            get
            {
                lock (percentageDoneSubtaskLock)
                {
                    return percentageDoneSubtask;
                }
            }

            set
            {
                lock (percentageDoneSubtaskLock)
                {
                    percentageDoneSubtask = value;
                }
            }
        }


    }
}
