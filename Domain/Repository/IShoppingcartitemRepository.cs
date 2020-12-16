using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;

namespace popsDiner.Domain.Repository
{
    public interface IShoppingcartitemRepository
    {
 public void AddToCart(Item item, int amount);
 public int RemoveFromCart(Item item);
public List<ShoppingCartItem> GetShoppingCartItems();
 public void ClearCart();
public decimal GetShoppingCartTotal();
 public string ShoppingCartId { get; set; }
public List<ShoppingCartItem> ShoppingCartItems { get; set; }




    }
}