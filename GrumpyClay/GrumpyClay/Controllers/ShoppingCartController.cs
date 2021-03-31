using GrumpyClay.Models;
using GrumpyClay.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISculptureRepository _sculptureRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISculptureRepository sculptureRepository, ShoppingCart shoppingCart)
        {
            _sculptureRepository = sculptureRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int sculptureId)
        {
            var selectedSculpture = _sculptureRepository.AllSculptures.FirstOrDefault(s => s.SculptureId == sculptureId);

            if (selectedSculpture != null)
            {
                _shoppingCart.AddToCart(selectedSculpture, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int sculptureId)
        {
            var selectedSculpture = _sculptureRepository.AllSculptures.FirstOrDefault(s => s.SculptureId == sculptureId);

            if (selectedSculpture != null)
            {
                _shoppingCart.RemoveFromCart(selectedSculpture);
            }
            return RedirectToAction("Index");
        }
    }
}
