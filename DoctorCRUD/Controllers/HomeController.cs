using DoctorCRUD.Data;
using DoctorCRUD.Model;
using DoctorCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoctorCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly DoctorDbContext _doctorDb;
     
        public HomeController(DoctorDbContext doctorDb)
        {
                _doctorDb = doctorDb;
                 
        }
        //Home Page
        public IActionResult Index()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}