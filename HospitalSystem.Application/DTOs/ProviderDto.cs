using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.DTOs
{
    public class ProviderDto
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Hospital { get; set; }

        public bool IsDoctor { get; set; }
    }
}
