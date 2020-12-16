using System.Collections.Generic;
using popsDiner.Application.DTO;
using popsDiner.Domain.Entities;

namespace popsDiner.Application.Mapping
{
public static class Mappingprofile
{
 public static Itemdto MappingitemDto(this Item item)
{
return new Itemdto
{
     ItemId=item.ItemId,
        Name=item.Name,
         shortDescription=item.shortDescription,
         LongDescription=item. LongDescription,
        AllergyInformation=item.AllergyInformation,
        Price=item.Price,
        ImageUrl=item.ImageUrl,
        ImageThumbnailUrl=item.ImageThumbnailUrl,
        isItemOfTheWeek=item.isItemOfTheWeek,
        InStock=item.InStock,
       CategoryId=item.CategoryId
};
}
public static Item MappingtoItem(this Itemdto itemdto)
{
return new Item
{
     ItemId=itemdto.ItemId,
        Name=itemdto.Name,
         shortDescription=itemdto.shortDescription,
         LongDescription=itemdto. LongDescription,
        AllergyInformation=itemdto.AllergyInformation,
        Price=itemdto.Price,
        ImageUrl=itemdto.ImageUrl,
        ImageThumbnailUrl=itemdto.ImageThumbnailUrl,
        isItemOfTheWeek=itemdto.isItemOfTheWeek,
        InStock=itemdto.InStock,
       CategoryId=itemdto.CategoryId
};
}
public static void MappingtoItem(this Itemdto itemdto, Item item)
        {  item.ItemId=itemdto.ItemId;
           item.Name=itemdto.Name;
         item.shortDescription=itemdto.shortDescription;
         item.LongDescription=itemdto. LongDescription;
        item.AllergyInformation=itemdto.AllergyInformation;
        item.Price=itemdto.Price;
        item.ImageUrl=itemdto.ImageUrl;
        item.ImageThumbnailUrl=itemdto.ImageThumbnailUrl;
        item.isItemOfTheWeek=itemdto.isItemOfTheWeek;
        item.InStock=itemdto.InStock;
       item.CategoryId=itemdto.CategoryId;
        }
   public static IEnumerable<Itemdto> MappingitemDtos(this IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                yield return item.MappingitemDto();
            }
        }
public static Categorydto MappingcategoryDto(this Category category)
{
return new Categorydto
{
    CategoryId =category.CategoryId,
        CategoryName=category.CategoryName,
         Description=category.Description
};
}
public static Category Mappingtocategory(this Categorydto categorydto)
{
return new Category
{
      CategoryId =categorydto.CategoryId,
        CategoryName=categorydto.CategoryName,
         Description=categorydto.Description
};
}
public static void Mappingtocategory(this Categorydto categorydto, Category category)
        {     categorydto.CategoryId =category.CategoryId;
        categorydto.CategoryName=category.CategoryName;
         categorydto.Description=category.Description;
        }
   public static IEnumerable<Categorydto> MappingcategoryDtos(this IEnumerable<Category> categories)
        {
            foreach (var category in categories)
            {
                yield return category.MappingcategoryDto();
            }
        }
public static Orderdto MappingorderDto(this Order order)
{
return new Orderdto
{
    OrderId=order.OrderId,
FirstName=order.FirstName,
LastName=order.LastName,
AddressLine1=order.AddressLine1,
AddressLine2=order.AddressLine2,
ZipCode=order.ZipCode,
 State=order.State,
Country=order.Country,
PhoneNumber=order.PhoneNumber,
Email=order.Email,
OrderTotal=order.OrderTotal,
OrderPlaced =order.OrderPlaced
};
}
public static Order Mappingtoorder(this Orderdto orderdto)
{
return new Order
{
      OrderId=orderdto.OrderId,
FirstName=orderdto.FirstName,
LastName=orderdto.LastName,
AddressLine1=orderdto.AddressLine1,
AddressLine2=orderdto.AddressLine2,
ZipCode=orderdto.ZipCode,
 State=orderdto.State,
Country=orderdto.Country,
PhoneNumber=orderdto.PhoneNumber,
Email=orderdto.Email,
OrderTotal=orderdto.OrderTotal,
OrderPlaced =orderdto.OrderPlaced
};
}
public static void Mappingtoorder(this Orderdto orderdto, Order order)
        {      orderdto.OrderId=order.OrderId;

orderdto.FirstName=order.FirstName;
orderdto.LastName=order.LastName;
orderdto.AddressLine1=order.AddressLine1;
orderdto.AddressLine2=order.AddressLine2;
orderdto.ZipCode=order.ZipCode;
 orderdto.State=order.State;
orderdto.Country=order.Country;
orderdto.PhoneNumber=order.PhoneNumber;
orderdto.Email=order.Email;
orderdto.OrderTotal=order.OrderTotal;
orderdto.OrderPlaced =order.OrderPlaced;
        }
   public static IEnumerable<Orderdto> MappingorderDtos(this IEnumerable<Order> orders)
        {
            foreach (var order in orders)
            {
                yield return order.MappingorderDto();
            }
        }
   public static OrderDetaildto MappingorderdetailDto(this OrderDetail orderdetail)
{
return new OrderDetaildto
{
  OrderDetailId=orderdetail.OrderDetailId,
  OrderId =orderdetail.OrderId,
   ItemId=orderdetail. ItemId,
   Amount=orderdetail.Amount,
    Price=orderdetail. Price
};
}
public static OrderDetail Mappingtoorderdetail(this OrderDetaildto orderdetaildto)
{
return new OrderDetail
{
    OrderDetailId=orderdetaildto.OrderDetailId,
  OrderId =orderdetaildto.OrderId,
   ItemId=orderdetaildto. ItemId,
   Amount=orderdetaildto.Amount,
    Price=orderdetaildto. Price
};
}
public static void Mappingtoorderdetail(this OrderDetaildto orderdetaildto,OrderDetail orderdetail)
{
 orderdetail.OrderDetailId=orderdetaildto.OrderDetailId;
  orderdetail.OrderId =orderdetaildto.OrderId;
   orderdetail.ItemId=orderdetaildto. ItemId;
  orderdetail.Amount=orderdetaildto.Amount;
    orderdetail.Price=orderdetaildto. Price;
}
public static IEnumerable<OrderDetaildto> MappingorderdetailDtos(this IEnumerable<OrderDetail> orderdetails)
        {
            foreach (var orderdetail in orderdetails)
            {
                yield return orderdetail.MappingorderdetailDto();
            }
        }
   public static  ShoppingCartItemdto MappingshoppingcartDto(this  ShoppingCartItem shoppingcart)
{
return new  ShoppingCartItemdto
{
   ShoppingCartItemId=shoppingcart.ShoppingCartItemId,
        Amount=shoppingcart.Amount,
         ShoppingCartId=shoppingcart.ShoppingCartId
};
}
  public static  ShoppingCartItem MappingtoshoppingcartDto(this  ShoppingCartItemdto shoppingcartdto)
{
return new  ShoppingCartItem
{
   ShoppingCartItemId=shoppingcartdto.ShoppingCartItemId,
        Amount=shoppingcartdto.Amount,
         ShoppingCartId=shoppingcartdto.ShoppingCartId
};
}
  public static  void MappingshoppingcartDto(this  ShoppingCartItemdto shoppingcartdto,ShoppingCartItem shoppingcart)
{


   shoppingcartdto.ShoppingCartItemId=shoppingcart.ShoppingCartItemId;
        shoppingcartdto.Amount=shoppingcart.Amount;
          shoppingcartdto.ShoppingCartId=shoppingcart.ShoppingCartId;
}
public static IEnumerable<ShoppingCartItemdto> MappingshoppingcartDtos(this IEnumerable<ShoppingCartItem> shoppingcarts)
        {
            foreach (var shoppingcart in shoppingcarts)
            {
                yield return shoppingcart.MappingshoppingcartDto();
            }
        }
}
}
