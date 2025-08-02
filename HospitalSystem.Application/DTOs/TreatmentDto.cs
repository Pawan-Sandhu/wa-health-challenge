using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.DTOs
{
    public class TreatmentDto
    {
        public string Details { get; set; }
        public string Hospital { get; set; }
        public string Provider { get; set; }

        public string PatientMRN { get; set; }
        public DateTime DischargedOn { get; set; }
    }
}
