using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment
{
    class Queen
    {
        Worker[] Workers = new Worker[4];
        int shiftNumber=0;

        public Queen(Worker[] workers)
        {
            Workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            bool assigned = false;
            foreach(Worker worker in Workers)
            {
                assigned = worker.DoThisJob(job, numberOfShifts);
                if (assigned)
                    break;
            }
            return assigned;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "\r\nReport for shift #" + shiftNumber + "\r\n";
            var n = 0;
            foreach (Worker worker in Workers)
            {
                n++;
                if (worker.CurrentJob == "")
                {
                    report += "Worker #" + n + " is not work.\r\n";
                }
                else
                {
                    if (worker.DidYouFinish())
                    {
                        report += "Worker #" + n + " finished the job.\r\n";
                    }
                    else
                    {
                        if (worker.ShiftsLeft == 1)
                            report += "Worker #" + n + " will be done '" + 
                                worker.CurrentJob + "'after this shift.\r\n";
                        else
                            report += "Worker #" + n + " is doing '" +
                                worker.CurrentJob + "' for " + worker.ShiftsLeft +
                                " more shifts.\r\n";
                    }
                }
            }
            return report;
        }
    }
    
}
