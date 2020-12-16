using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
namespace popsDiner.Infrastructure.Persistence
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;
       
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> Items
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category);
            }
        }
         
        public IEnumerable<Item> ItemsOfTheWeek
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category).Where(i => i.isItemOfTheWeek);
            }
        }

        public Item GetItemById(int ItemId)
        {
            return _appDbContext.Items.FirstOrDefault(i => i.ItemId == ItemId);
        }

        public IEnumerable<Item> GetItemByName(string name)
        {
            return _appDbContext.Items.Where(i => i.Category.CategoryName == name);
        }

    }
}
