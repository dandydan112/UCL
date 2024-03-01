using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models
{
    public class Availability
    {
        public int AvailabilityID { get; set; }
        public DateTime Date { get; set; }
        public int Timeframe { get; set; }
        public int TimeframeId { get; set; }
        public int SubstituteId { get; set; }
    }
}
