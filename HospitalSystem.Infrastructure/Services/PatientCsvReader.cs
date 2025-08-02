using CsvHelper;
using HospitalSystem.Application.DTOs;
using HospitalSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Services
{
    public class PatientCsvReader : IDataReader<PatientDto>
    {
        public List<PatientDto> ReadData(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<PatientDto>().ToList();
        }

       
    }
}
