using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class Treatment
    {
        public int TreatId { get; }
        public string Service { get; set; }
        public DateTime Date { get; set; }
        public double Charge { get; set; }

        public Treatment(int treatId)
        {
            TreatId = treatId;
        }

        public override string ToString()
        {
            return $"{TreatId}: {Service} on {Date} costs {Charge}";
        }
    }
}
