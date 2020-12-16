using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
using popsDiner.Application.Mapping;
using popsDiner.ViewModels;
namespace popsDiner.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IItemService _itemRepository;
        private readonly IshoppingcartService _shoppingCart;

        public ShoppingCartController(IItemService itemRepository, IshoppingcartService shoppingCart)
        {
            _itemRepository = itemRepository;
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

        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.Items.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem, 1);
            }
            return RedirectToAction("Index");
        }


        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.Items.FirstOrDefault(p => p.ItemId == itemId);

            if (selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }
        public ActionResult ClearShoppingCart()
        {
            _shoppingCart.ClearCart();
            return Redirect("Index");
        }
        
    }
}