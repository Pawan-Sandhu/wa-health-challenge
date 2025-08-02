using HospitalSystem.Application.DTOs;
using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var hospitals = _dataService.GetAllHospitals();
            ViewBag.Hospitals = new SelectList(hospitals, "Id", "Name");
            return View();
           
        }       

        [HttpPost]
        public IActionResult ProvidersByHospital(string hospitalId)
        {
            var hospitals = _dataService.GetAllHospitals();
            ViewBag.Hospitals = new SelectList(hospitals, "Id", "Name", hospitalId);

            var providers = _dataService.GetProvidersByHospital(hospitalId);
            return View(providers); // Send list to view
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
