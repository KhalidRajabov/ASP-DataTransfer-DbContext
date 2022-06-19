using DataTransfer.Models;
using DataTransfer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*ViewBag.name = "Xalid";
            ViewData["Surname"] = "Recebov";
            ViewData["Name"] = "Xalid";
            TempData["Age"] = 27;*/

            //ViewBag.students = students;
            //return RedirectToAction(nameof(About));

            //ViewBag.Group = groups;



            List<Student> students = new List<Student>
            {
                new Student { Name = "Xalid", Id = 1, Surname = "Rajabov"},
                new Student { Name = "Cavid", Id = 2, Surname = "Aliyev"}
            };
            List<Group> groups = new List<Group>
            {
                new Group { Name = "Qrup", Id=1, },
                new Group { Name = "Qurup", Id=2, }
            };
            HomeVM home = new HomeVM();
            home.Groups = groups;
            home.Students = students;
            return View(home);
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
