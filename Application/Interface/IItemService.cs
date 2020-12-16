using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Application.DTO;
using popsDiner.Application.Services;
namespace popsDiner.Application.Interface
{
    public interface IItemService
    {
        IEnumerable<Itemdto> Items { get; }
        IEnumerable<Itemdto> ItemsOfTheWeek { get; }
        Itemdto GetItemById(int itemId);
        IEnumerable<Itemdto> GetItemByname(string name);
    }
}
