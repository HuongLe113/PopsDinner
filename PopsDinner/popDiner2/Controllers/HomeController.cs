using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using popsDiner.ViewModels;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
using popsDiner.Application.Mapping;
namespace popsDiner.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemService _itemRepository;
        private readonly IshoppingcartService _shoppingcart;
        public HomeController(IItemService itemRepository,IshoppingcartService shoppingcart)
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