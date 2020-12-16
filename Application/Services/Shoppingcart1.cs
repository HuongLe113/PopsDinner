using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using popsDiner.Application.Mapping;
using popsDiner.Application.Interface;
using popsDiner.Application.DTO;
using popsDiner.Infrastructure.Persistence;
namespace popsDiner.Application.Services
{
    public class Shoppingcart1 : IshoppingcartService
 {
     private readonly ShoppingCart shopping;
     public Shoppingcart1(ShoppingCart shopping)
     {
         this.shopping=shopping;
     }
    public void AddToCart(Itemdto item, int amount)
    {
        var item1=item.MappingtoItem();
        shopping.AddToCart(item1,amount);
    }
public int RemoveFromCart(Itemdto item)
 {
      var item1=item.MappingtoItem();
      var shopping2=shopping.RemoveFromCart(item1);
      return shopping2;
 }
 public List<ShoppingCartItemdto> GetShoppingCartItems()
 {
     var shopping2=shopping.GetShoppingCartItems();
    List<ShoppingCartItemdto> t2= new List<ShoppingCartItemdto>();
    for(int i=0;i<shopping2.Count;i++)
    {
        var t=shopping2[i].MappingshoppingcartDto();
        t2.Add(t);
    }
    return t2.ToList();

 }
  public void ClearCart()
  {
      shopping.ClearCart();
  }
public decimal GetShoppingCartTotal()
{
    var total1=shopping.GetShoppingCartTotal();
    return total1;
}

 public string ShoppingCartId { get; set; }

 public List<ShoppingCartItemdto> ShoppingCartItems { get; set;}
  }
}