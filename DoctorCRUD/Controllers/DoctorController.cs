using DoctorCRUD.Data;
using DoctorCRUD.Model;
using DoctorCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoctorCRUD.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DoctorDbContext _doctorDb;
     
        public DoctorController(DoctorDbContext doctorDb)
        {
                _doctorDb = doctorDb;
                 
        }
      
        //Doctor Crud
        public IActionResult Doctor()
        {
            var docData = _doctorDb.doctors.ToList();
            return View(docData);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _doctorDb.doctors.AddAsync(doctor);
                _doctorDb.SaveChanges();
                return RedirectToAction("Doctor" , "Doctor");
            }
            return View(doctor);
        }

        public IActionResult Details(int? id)
        {
            if (id == null || _doctorDb.doctors == null)
            {
                return NotFound();
            }

            var docData = _doctorDb.doctors.FirstOrDefault(x => x.Id == id);
            if (docData == null)
            {
                return NotFound();
            }
            return View(docData);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || _doctorDb.doctors == null)
            {
                return NotFound();
            }
            var docData = _doctorDb.doctors.Find(id);
            if (docData == null)
            {
                return NotFound();
            }
            return View(docData);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Doctor doctor)
        {
            if (id != doctor.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _doctorDb.doctors.Update(doctor);
                _doctorDb.SaveChanges();
                return RedirectToAction("Doctor");
            }
            return View(doctor);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || _doctorDb.doctors == null)
            {
                return NotFound();
            }
            var docData = _doctorDb.doctors.FirstOrDefault(x => x.Id == id);
            if (docData == null)
            {
                return NotFound();
            }
            return View(docData);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var docData = _doctorDb.doctors.Find(id);
            if (docData != null)
            {
                _doctorDb.doctors.Remove(docData);
            }
            _doctorDb.SaveChanges();
            return RedirectToAction("Doctor");


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}