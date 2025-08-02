using HospitalSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Interfaces
{
    public interface IDataService
    {
        List<PatientDto> GetAllPatients();
        List<ProviderDto> GetAllProviders();
        List<TreatmentDto> GetAllTreatments();
        List<HospitalDto> GetAllHospitals();

        List<ProviderDto> GetProvidersByHospital(string hospitalId);
        List<string> GetPatientMrnsByDoctor(string doctorId);
        List<PatientDto> GetUntreatedPatientsAtHospital(string hospitalId);
        void CreateTreatment(TreatmentDto treatment);
        void UpdateTreatment(TreatmentDto treatment);
    }
}
