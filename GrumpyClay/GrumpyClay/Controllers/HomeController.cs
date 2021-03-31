using GrumpyClay.Models;
using GrumpyClay.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISculptureRepository _sculptureRepository;

        public HomeController(ISculptureRepository sculptureRepository)
        {
            _sculptureRepository = sculptureRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SculpturesOfTheWeek = _sculptureRepository.SculpturesOfTheWeek
            };
            
            return View(homeViewModel);
        }
    }
}
