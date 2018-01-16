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
        int shiftNumber;

        public Queen(Worker[] workers)
        {
            Workers = workers;
        }

        public bool AssignWork(string work, int shifts)
        {
            return true;
        }

        public string WorkTheNextShift()
        {
            return "";
        }
    }
    
}
