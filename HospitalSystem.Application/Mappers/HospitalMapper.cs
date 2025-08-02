using HospitalSystem.Application.DTOs;
using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Mappers
{
    public static class HospitalMapper
    {
        public static HospitalDto ToDto(Hospital h) => new HospitalDto
        {
            Identity = h.Identity,
            Name = h.Name
        };

        public static Hospital ToDomain(HospitalDto dto) => new Hospital
        {
            Identity = dto.Identity,
            Name = dto.Name
        };
    }
}
