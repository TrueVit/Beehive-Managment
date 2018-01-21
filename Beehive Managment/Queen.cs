using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment
{
    class Queen:Bee
    {
        Worker[] Workers = new Worker[4];
        int shiftNumber=0;

        public Queen(Worker[] workers, double wightMg):base(wightMg)
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
            double honeyConsumed = HoneyConsumptionRate();

            shiftNumber++;
            string report = "\r\nReport for shift #" + shiftNumber + "\r\n";
            var n = 0;
            foreach (Worker worker in Workers)
            {
                n++;
                
                if (String.IsNullOrEmpty(worker.CurrentJob))
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
                        if (worker.ShiftsLeft == 0)
                            report += "Worker #" + n + " will be done '" + 
                                worker.CurrentJob + "' after this shift.\r\n";
                        else
                            report += "Worker #" + n + " is doing '" +
                                worker.CurrentJob + "' for " + worker.ShiftsLeft +
                                " more shifts.\r\n";
                    }
                }
                honeyConsumed += worker.HoneyConsumptionRate();
            }
            report += "Total honey consumed for the shift: " + honeyConsumed + " units\r\n";
            return report;
        }
    }
    
}
