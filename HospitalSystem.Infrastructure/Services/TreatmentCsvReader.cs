using CsvHelper;
using HospitalSystem.Domain.Entities;
using HospitalSystem.Domain.Interfaces;
using HospitalSystem.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Services
{
    public class TreatmentCsvReader : IDataReader<Treatment>
    {
        public List<Treatment> ReadData(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var rawData = csv.GetRecords<Treatment>().ToList();
            return rawData.Where(p => TreatmentValidator.IsValid(p)).ToList();
        }

       
    }
}
