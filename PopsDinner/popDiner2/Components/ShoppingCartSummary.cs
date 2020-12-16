using Microsoft.AspNetCore.Mvc;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
using popsDiner.Application.Mapping;
using popsDiner.Infrastructure.Persistence;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  popsDiner.ViewModels;
namespace popsDiner.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IshoppingcartService  _shoppingCart;

            public ShoppingCartSummary(IshoppingcartService shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems= items;

            var ShoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(ShoppingCartViewModel);
        }
    }
}
