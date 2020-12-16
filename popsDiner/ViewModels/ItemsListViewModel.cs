using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;

using Microsoft.AspNetCore.Mvc.Rendering;

using popsDiner.Infrastructure;
namespace popsDiner.ViewModels
  {
    public class ItemsListViewModel
    {
        public PagedList<Item> Items { get; set; }
        public string CurrentCategory { get; set; }
        public SelectList Genres {get;set;}
        
        public String itemgenres {get;set;}
    }
}
