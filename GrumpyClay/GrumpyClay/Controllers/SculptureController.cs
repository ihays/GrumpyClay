using GrumpyClay.Models;
using GrumpyClay.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Controllers
{
    public class SculptureController : Controller
    {
        private readonly ISculptureRepository _sculptureRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SculptureController(ISculptureRepository sculptureRepository, ICategoryRepository categoryRepository)
        {
            _sculptureRepository = sculptureRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List(string category)
        //{
        //    SculpturesListViewModel sculpturesListViewModel = new SculpturesListViewModel();
        //    sculpturesListViewModel.Sculptures = _sculptureRepository.AllSculptures;
            
        //    sculpturesListViewModel.CurrentCategory = "Cartoon";
        //    return View(sculpturesListViewModel);
        //}

        public IActionResult Details(int id)
        {
            var sculpture = _sculptureRepository.GetSculptureById(id);
            if(sculpture == null)
            {
                return NotFound();
            }
            return View(sculpture);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Sculpture> sculptures;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                sculptures = _sculptureRepository.AllSculptures.OrderBy(s => s.SculptureId);
                currentCategory = "All sculptures";
            }
            else
            {
                sculptures = _sculptureRepository.AllSculptures.Where(s => s.Category.CategoryName == category)
                    .OrderBy(s => s.SculptureId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new SculpturesListViewModel
            {
                Sculptures = sculptures,
                CurrentCategory = currentCategory
            });
        }
    }
}
