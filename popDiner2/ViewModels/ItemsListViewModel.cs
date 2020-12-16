using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using popsDiner.Infrastructure;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.TagHelpers.PagedList;
namespace popsDiner.ViewModels
  {
    public class ItemsListViewModel
    {
        public PagedList<Itemdto> Items { get; set; }
        public string CurrentCategory { get; set; }
        public SelectList Genres {get;set;}
        
        public String itemgenres {get;set;}
    }
}
