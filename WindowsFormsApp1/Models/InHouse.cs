using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class InHouse : Part
    {
        private int machineID;

        public void SetMachineID(int newMachineID)
        {
            machineID = newMachineID;
        }

        public int GetMachineID()
        {
            return machineID;
        }
    }
}
