using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Xalid";
            ViewData["Surname"] = "Recebov";
            TempData["Age"] = 27;

            List <Student> students = new List<Student>
            {
                new Student { Name = "Xalid", Id = 1, Surname = "Rajabov"},
                new Student { Name = "Cavid", Id=2, Surname = "Aliyev"}
            };

            ViewBag.students = students;
            //return RedirectToAction(nameof(About));
            return View();

        }
        public IActionResult About()
        {
            return View();
        }
    }
}
