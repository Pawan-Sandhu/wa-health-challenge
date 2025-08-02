using HospitalSystem.Application.DTOs;
using HospitalSystem.Application.Interfaces;
using HospitalSystem.Application.Mappers;
using HospitalSystem.Domain.Entities;
using HospitalSystem.Domain.Validation;
using HospitalSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Services
{
    public class DataService : IDataService
    {
        private readonly List<PatientDto> _patients;
        private readonly List<ProviderDto> _providers;
        private readonly List<HospitalDto> _hospitals;
        private readonly List<TreatmentDto> _treatments;

        public DataService()
        {
            var domainPatients = new PatientCsvReader().ReadData("wwwroot/data/Patients.csv");
            var _patients = domainPatients.Select(PatientMapper.ToDto).ToList();

            var domainProviders = new ProviderCsvReader().ReadData("wwwroot/data/Providers.csv");
            var _providers = domainProviders.Select(ProviderMapper.ToDto).ToList();

            var domainHospitals = new HospitalCsvReader().ReadData("wwwroot/data/Hospitals.csv");
            var _hospitals = domainHospitals.Select(HospitalMapper.ToDto).ToList();

            var domainTreatments = new TreatmentCsvReader().ReadData("wwwroot/data/Treatments.csv");
            var _treatments = domainTreatments.Select(TreatmentMapper.ToDto).ToList();           
        }

        

        public List<ProviderDto> GetProvidersByHospital(string hospitalId)
        {
            return _providers.Where(p => p.Hospital == hospitalId).ToList();
        }

        public List<string> GetPatientMrnsByDoctor(string doctorId)
        {
            var treated = _treatments.Where(t => t.Provider == doctorId);
            return treated                
                .Select(p => p.PatientMRN)
                .Distinct()
                .ToList();
        }

        public List<PatientDto> GetUntreatedPatientsAtHospital(string hospitalId)
        {
            var treatedIds = _treatments.Select(t => t.PatientMRN).Distinct();
            return _patients
                .Where(p => !treatedIds.Contains(p.MedicalReferenceNumber))
                .ToList();
        }

        public void CreateTreatment(TreatmentDto treatment)
        {
            // Save to file or DB (not implemented)
        }

        public void UpdateTreatment(TreatmentDto treatment)
        {
            // Save changes (not implemented)
        }

        public List<PatientDto> GetAllPatients()
        {
            return _patients.ToList();
        }

        public List<ProviderDto> GetAllProviders()
        {
            return _providers.ToList();
        }

        public List<TreatmentDto> GetAllTreatments()
        {
            return _treatments.ToList();
        }

        public List<HospitalDto> GetAllHospitals()
        {
            return _hospitals.ToList();
        }
    }
}
