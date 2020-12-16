using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Domain.Entities;
using Infrastructure.Persistence;

namespace popsDiner.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ShoppingCart _shoppingcart;
        public HomeController(IItemRepository itemRepository,ShoppingCart shoppingcart)
        {
            _itemRepository = itemRepository;
            _shoppingcart=shoppingcart;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemsOfTheWeek = _itemRepository.ItemsOfTheWeek
            };

            return View(homeViewModel);
        }
        public RedirectToActionResult addshoppingCart(int itemId)
        {
              var selecteditem=_itemRepository.Items.FirstOrDefault(p=>p.ItemId==itemId);
              if(selecteditem!=null)
              {
                  _shoppingcart.AddToCart(selecteditem,1);
              }
            return RedirectToAction("Index");
        }
    }
}