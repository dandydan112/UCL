using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models
{
    public class Substitute
    {
        public int SubstituteId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string SSN { get; set; }
        public DateTime ChildCertificateExpiryDate { get; set; }
        public bool Active { get; set; }
    }
}
