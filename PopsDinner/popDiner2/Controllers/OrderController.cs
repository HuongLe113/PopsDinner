using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
using popsDiner.Application.Mapping;
namespace popsDiner.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderRepository;
        private readonly IshoppingcartService _shoppingCart;
        public OrderController(IOrderService orderRepository, IshoppingcartService shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Orderdto order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some food first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);

        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = HttpContext.User.Identity.Name +
                                      " thanks for your order. You'll soon enjoy our delicious burgers!";
            return View();
        }
    }
}