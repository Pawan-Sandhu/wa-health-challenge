using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Entities
{
    public class Treatment
    {
        public string Details { get; set; }
        public string Hospital { get; set; }
        public string Provider { get; set; }
        [Name("Patient")]
        public string PatientMRN { get; set; }
        [Name("Date/Time Discharged")]
        public string DischargedOn { get; set; }


    }
}
