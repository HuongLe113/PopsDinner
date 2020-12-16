using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Mapping;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
namespace popsDiner.Application.Services
{
 public class ItemService : IItemService
    {
        private readonly IItemRepository itemrepository;
        public ItemService(IItemRepository itemrepository)
        {
   this.itemrepository=itemrepository;
        }
   public  IEnumerable<Itemdto> Items
{   get{
    var item=itemrepository.Items;
    return item.MappingitemDtos();
}
}

public IEnumerable <Itemdto> ItemsOfTheWeek
{get{
  var item=itemrepository.ItemsOfTheWeek;
  return item.MappingitemDtos();
}
}
public Itemdto GetItemById(int itemId)
{
    var item=itemrepository.GetItemById(itemId);
    return item.MappingitemDto();  
}
public IEnumerable< Itemdto> GetItemByname(string name)
{
    var item=itemrepository.GetItemByName(name);
    return item.MappingitemDtos();
}
    }
}
