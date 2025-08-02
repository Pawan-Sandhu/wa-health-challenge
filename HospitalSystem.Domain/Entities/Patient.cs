using CsvHelper.Configuration.Attributes;

namespace HospitalSystem.Domain.Entities
{
    public class Patient
    {
        [Name("Medical Reference Number")]
        public string MedicalReferenceNumber { get; set; }

        [Name("Patient Name")]
        public string Name { get; set; }

    }
}
