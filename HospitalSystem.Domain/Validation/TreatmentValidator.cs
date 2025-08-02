using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Validation
{
    public static class TreatmentValidator
    {
        public static bool IsValid(Treatment treatment)
        {
            if (string.IsNullOrWhiteSpace(treatment.Hospital) || string.IsNullOrWhiteSpace(treatment.PatientMRN))
                return false;

            if (!string.IsNullOrWhiteSpace((treatment.DischargedOn)))
            {
                if (string.IsNullOrWhiteSpace(treatment.Provider) || string.IsNullOrWhiteSpace(treatment.Details))
                    return false;

            }
            return true;
        }
    }
}
