using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Validation
{
    public static class PatientValidator
    {
        public static bool IsValid(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(patient.MedicalReferenceNumber) || string.IsNullOrWhiteSpace(patient.Name))
                return false;

            var name = patient.Name.Trim();
            if (name.Split(' ').Length < 2 || name.Length < 5)
                return false;

            var validNamePattern = @"^[a-zA-Z\s'-]+$";
            return Regex.IsMatch(name, validNamePattern);
        }
    }
}
