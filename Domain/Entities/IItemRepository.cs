using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item GetItemById(int itemId);
    }
}
