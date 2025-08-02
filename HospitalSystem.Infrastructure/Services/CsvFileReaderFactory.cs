using HospitalSystem.Domain.Interfaces;
using HospitalSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Factory
{
    public class CsvFileReaderFactory : IDataReaderFactory
    {
        public IDataReader GetReader(string entityType)
        {
            return entityType switch
            {
                "Patient" => new PatientCsvReader(),
                "Hospital" => new HospitalCsvReader(),
                "Provider" => new ProviderCsvReader(),
                "Treatment" => new TreatmentCsvReader(),
                _ => throw new ArgumentException("Invalid entity type")
            };
        }
    }
}
