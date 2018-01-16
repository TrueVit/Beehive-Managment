using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment
{
    class Worker
    {
        string[] JobsICanDo;
        int shiftsToWork;
        int shiftsWorked;

        public string CurrentJob;
        public int ShiftsLeft;

        public Worker(string[] jobsICanDo)
        {
            JobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int shifts)
        {
            return true;
        }

        public bool DidYouFinish()
        {
            return true;
        }
    }
}
