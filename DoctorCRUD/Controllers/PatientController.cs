using DoctorCRUD.Data;
using DoctorCRUD.Model;
using DoctorCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoctorCRUD.Controllers
{
    public class PatientController : Controller
    {
        
        private readonly DoctorDbContext _patientDb;
        public PatientController( DoctorDbContext patientDb)
        {
                
                  _patientDb = patientDb;
        }
       
        //Patient Crud
        public IActionResult Patient()
        {
            var patientData = _patientDb.patients.ToList();
            return View(patientData);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _patientDb.patients.AddAsync(patient);
                _patientDb.SaveChanges();
                return RedirectToAction("Patient","Patient");
            }
            return View(patient);
        }
        public IActionResult Details(int? id)
        {
            if (id == null || _patientDb.patients == null)
            {
                return NotFound();
            }

            var patientData = _patientDb.patients.FirstOrDefault(x => x.Id == id);
            if (patientData == null)
            {
                return NotFound();
            }
            return View(patientData);
        }



        public IActionResult Edit(int? id)
        {
            if (id == null || _patientDb.patients == null)
            {
                return NotFound();
            }
            var docData = _patientDb.patients.Find(id);
            if (docData == null)
            {
                return NotFound();
            }
            return View(docData);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _patientDb.patients.Update(patient);
                _patientDb.SaveChanges();
                return RedirectToAction("Patient");
            }
            return View(patient);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || _patientDb.patients == null)
            {
                return NotFound();
            }
            var docData = _patientDb.patients.FirstOrDefault(x => x.Id == id);
            if (docData == null)
            {
                return NotFound();
            }
            return View(docData);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var docData = _patientDb.patients.Find(id);
            if (docData != null)
            {
                _patientDb.patients.Remove(docData);
            }
            _patientDb.SaveChanges();
            return RedirectToAction("Patient");


        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}