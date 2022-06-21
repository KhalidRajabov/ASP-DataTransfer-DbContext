using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            //slider ToList metodu ishledir chunki tekrarlanan datalar var
            homeVM.Sliders = _context.Sliders.ToList();

            //tekrarlanan data olmadigi uchun ToList yazilmir, firstordefault yazilir ki data choxdursa
            //en birinci datani, eger yoxdursa null gelsin
            homeVM.SliderContent = _context.SliderContents.FirstOrDefault();

            //eyni qaydada, tekrarlanan datalar oldugu uchun tolist atilir
            homeVM.Categories = _context.Categories.ToList();
            return View(homeVM);
        }
    }
}
