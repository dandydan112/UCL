using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    // Definition af ProcessStateType enumeration
    public enum ProcessStateType { New, Ready, Running, Waiting, Terminated }

    public class PCB
    {
        // Properties til at holde information om processen
        public string ProcessName { get; set; }
        public int ProcessPriority { get; set; }
        public ProcessStateType ProcessState { get; set; }

        // Konstruktor for nem initialisering
        public PCB(string name, int priority, ProcessStateType state)
        {
            ProcessName = name;
            ProcessPriority = priority;
            ProcessState = state;
        }

        // Override af ToString() metoden for at returnere en specifik tekstrepræsentation
        public override string ToString()
        {
            return $"{ProcessName}({ProcessPriority})";
        }
    }

}

