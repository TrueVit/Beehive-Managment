using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment
{
    class Worker:Bee
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

        public Worker(string[] jobsICanDo, double weightMg):base(weightMg)
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
            if (shiftsWorked <= shiftsToWork)
                return false;
            currentJob = "";
            shiftsToWork = 0;
            shiftsWorked = 0;
            return true;
        }

        const double honeyUnitsPerShiftWorked = .65;

        public override double HoneyConsumptionRate()
        {
            double consumptionRate=base.HoneyConsumptionRate();
            consumptionRate += shiftsWorked * honeyUnitsPerShiftWorked;
            return consumptionRate;
        }
    }
}
