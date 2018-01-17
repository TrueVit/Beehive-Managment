using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment
{
    class Worker
    {
        string[] jobsICanDo;
        int shiftsToWork;
        int shiftsWorked;
        string currentJob="";

        public string CurrentJob
        {
            get { return currentJob; }
        }
        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
            //currentJob = "";
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (CurrentJob != "")
                return false;
            foreach(string _job in jobsICanDo)
            {
                if (_job == job)
                {
                    currentJob = job;
                    shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    break;
                }
            }
            return (CurrentJob != "");
        }

        public bool DidYouFinish()
        {
            shiftsWorked++;
            if (shiftsWorked < shiftsToWork)
                return false;
            currentJob = "";
            return true;
        }
    }
}
