using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Validation
{
    public static class HospitalValidator
    {
        public static bool IsValid(Hospital hospital)
        {
            return !string.IsNullOrWhiteSpace(hospital.Identity) &&
                   !string.IsNullOrWhiteSpace(hospital.Name);
        }
    }
}
