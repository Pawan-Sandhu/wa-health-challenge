using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Validation
{
    public static class ProviderValidator
    {
        public static bool IsValid(Provider provider)
        {
            if (string.IsNullOrWhiteSpace(provider.Number) || string.IsNullOrWhiteSpace(provider.Name))
                return false;

            var name = provider.Name.Trim();
            if (name.Split(' ').Length < 2 || name.Length < 5)
                return false;

            var validNamePattern = @"^[a-zA-Z\s'-]+$";
            return Regex.IsMatch(provider.Name.Trim(), validNamePattern);
        }
    }
}
