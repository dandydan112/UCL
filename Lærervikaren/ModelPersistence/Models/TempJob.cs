using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models
{
    public class TempJob
    {
        public int TempJobId { get; set; }
        public decimal WorkingHours { get; set; }
        public int SubjectId { get; set; }
        public int AvailabilityId { get; set; }
        public int SchoolId { get; set; }
        public int InvoiceId { get; set; }
    }
}
