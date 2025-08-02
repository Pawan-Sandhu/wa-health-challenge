using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Entities
{
    public class Provider
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Hospital { get; set; }
        [Name("Doctor")]
        public string Doctor { get; set; }
    }
}
