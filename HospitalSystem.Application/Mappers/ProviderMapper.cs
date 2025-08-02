using HospitalSystem.Application.DTOs;
using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Mappers
{
    public static class ProviderMapper
    {
        public static ProviderDto ToDto(Provider p) => new ProviderDto
        {
            Number = p.Number,
            Name = p.Name,
            Hospital = p.Hospital,
            Doctor = p.Doctor
        };

        public static Provider ToDomain(ProviderDto dto) => new Provider
        {
            Number = dto.Number,
            Name = dto.Name,
            Hospital = dto.Hospital,
            Doctor = dto.Doctor
        };
    }
}
