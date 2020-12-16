using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
using popsDiner.Application.DTO;
namespace popsDiner.Application.Interface
{
public interface IshoppingcartService
    {
public void AddToCart(Itemdto item, int amount);
 public int RemoveFromCart(Itemdto item);
public List<ShoppingCartItemdto> GetShoppingCartItems();
 public void ClearCart();
public decimal GetShoppingCartTotal();

 public string ShoppingCartId { get; set;}
 public List<ShoppingCartItemdto> ShoppingCartItems { get; set;}
    }
}