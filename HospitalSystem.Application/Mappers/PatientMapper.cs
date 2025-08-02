using HospitalSystem.Application.DTOs;
using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Mappers
{
    public static class PatientMapper
    {
        public static PatientDto ToDto(Patient p) => new PatientDto
        {
            MedicalReferenceNumber = p.MedicalReferenceNumber,
            Name = p.Name
        };

        public static Patient ToDomain(PatientDto dto) => new Patient
        {
            MedicalReferenceNumber = dto.MedicalReferenceNumber,
            Name = dto.Name
        };
    }
}
