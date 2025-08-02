using HospitalSystem.Application.DTOs;
using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IDataAccessFactory _dataAccessFactory;
        private readonly IDataService _dataService;
        public HospitalController(IDataAccessFactory dataAccessFactory, IDataService dataService)
        {
            _dataAccessFactory = dataAccessFactory;
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ProvidersByHospital(string hospitalId)
        {
            var providers = _dataService.GetProvidersByHospital(hospitalId);
            ViewBag.HospitalId = hospitalId;
            return View(providers);
        }


        public IActionResult PatientMrnsByDoctor(string doctorId)
        {
            var mrns = _dataService.GetPatientMrnsByDoctor(doctorId);
            ViewBag.DoctorId = doctorId;
            return View(mrns);
        }


        public IActionResult UntreatedPatients(string hospitalId)
        {
            var patients = _dataService.GetUntreatedPatientsAtHospital(hospitalId);
            ViewBag.HospitalId = hospitalId;
            return View(patients);
        }


        [HttpGet]
        public IActionResult CreateTreatment()
        {
            return View(new TreatmentDto());
        }


        [HttpPost]
        public IActionResult CreateTreatment(TreatmentDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            _dataService.CreateTreatment(dto);
            return RedirectToAction("Index");
        }



        [HttpPost]
        public IActionResult EditTreatment(TreatmentDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            _dataService.UpdateTreatment(dto);
            return RedirectToAction("Index");
        }
    }

}
