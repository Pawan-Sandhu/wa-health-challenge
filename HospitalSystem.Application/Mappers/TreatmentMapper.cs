using HospitalSystem.Application.DTOs;
using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Mappers
{
    public static class TreatmentMapper
    {
        public static TreatmentDto ToDto(Treatment t) => new TreatmentDto
        {
            Provider = t.Provider,
            PatientMRN = t.PatientMRN,
            Hospital = t.Hospital,
            DischargedOn = t.DischargedOn,            
            Details = t.Details
        };

        public static Treatment ToDomain(TreatmentDto dto) => new Treatment
        {
            Provider = dto.Provider,
            PatientMRN = dto.PatientMRN,
            Hospital = dto.Hospital,
            DischargedOn = dto.DischargedOn,
            Details = dto.Details
        };
    }
}
