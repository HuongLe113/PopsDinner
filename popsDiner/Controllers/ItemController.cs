using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Infrastructure.Persistence;
using popsDiner.ViewModels;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Rendering;
using popsDiner.Infrastructure;

namespace popsDiner.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ShoppingCart _shoppingcart;

       public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository,ShoppingCart shoppingcart)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
            _shoppingcart=shoppingcart;
        }

        public ViewResult List(string category,string option,String itemgenre,int pageindex=1)
        {  
          
            IEnumerable<Item> Items;
              string[] input1={"Sắp xếp","Tên","Gía"};
             List<string> genre1=new List<string>(input1);
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category)||category=="All Items")
            {
                Items = _itemRepository.Items.OrderBy(p => p.ItemId);
                currentCategory = "All Items";
            }
            else
            {    
                 Items = _itemRepository.Items.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ItemId);
                
                 currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            ViewBag.CurrentCategory=currentCategory;
               string _option=option;
            if(!string.IsNullOrEmpty(category) && category!="All Items")
               {
                switch(_option)
          {  
              case "Sắp xếp":
              Items=_itemRepository.Items.Where(m=>m.Category.CategoryName==category).OrderBy(m=>m.ItemId);
              break;
              case "Tên":
              Items=_itemRepository.Items.Where(m=>m.Category.CategoryName==category).OrderBy(m=>m.Name);
             
              break;
              case "Gía":
              Items=_itemRepository.Items.Where(m=>m.Category.CategoryName==category).OrderBy(m=>m.Price);
           
              break;
              default:
              break;
          }
        }
        else{
              switch(_option)
          {  
              case "Sắp xếp":
              Items=_itemRepository.Items.OrderBy(m=>m.ItemId);
              break;
              case "Tên":
              Items=_itemRepository.Items.OrderBy(m=>m.Name);
             
              break;
              case "Gía":
              Items=_itemRepository.Items.OrderBy(m=>m.Price);
           
              break;
              default:
              break;
          }
        }
          itemgenre=_option;
            int count=Items.Count();
            int pagesize=3;
            return View(new ItemsListViewModel
            {
                Items = new PagedList<Item>(Items.Skip((pageindex-1)*pagesize).Take(pagesize).ToList(),count,pagesize,pageindex),
                CurrentCategory = currentCategory,
                Genres=new SelectList(genre1),
                itemgenres=itemgenre
            });
        }
        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
        public ViewResult Search(String search,string option,string itemgenre,string category,int pageindex=1)
        {     string _option=option;
            string _search=search;
              string[] input1={"Sắp xếp","Tên","Gía"};
             List<string> genre1=new List<string>(input1);
            IEnumerable<Item> item1;
            string currentCategory=String.Empty;
            int num;
            Item item2;
            if((String.IsNullOrEmpty(_search)))
            {
             item1=_itemRepository.Items.OrderBy(p=>p.ItemId);
             num=0;
            }
            else
            {   
            item1=_itemRepository.Items.Where(p=>p.Name.ToLower().Contains(_search.ToLower()));
              int t1=item1.Count();
              if(t1==0)
              {
                  item1=_itemRepository.Items.OrderBy(p=>p.ItemId);
                  num=0;
              }
              else{
                  
                num=1;
              }
            
            }
            if(num==1)
            {item2=item1.First();
            currentCategory=_categoryRepository.Categories.FirstOrDefault(p=>p.CategoryId==(item2.CategoryId)).CategoryName;
            }
            else{
                currentCategory="All category";
            }
            switch(_option)
          {  
              case "Sắp xếp":
              item1=_itemRepository.Items.Where(m=>m.Category.CategoryName==category).OrderBy(m=>m.ItemId);
              break;
              case "Tên":
              item1=_itemRepository.Items.Where(m=>m.Category.CategoryName==category).OrderBy(m=>m.Name);
             
              break;
              case "Gía":
              item1=_itemRepository.Items.Where(m=>m.Category.CategoryName==category).OrderBy(m=>m.Price);
           
              break;
              default:
              break;
          }
            int count=item1.Count();
            int pagesize=3;
           return View("~/Views/Item/List.cshtml",new ItemsListViewModel{Items= new PagedList<Item>(item1.Skip((pageindex-1)*pagesize).Take(pagesize),count,pagesize,pageindex),CurrentCategory=currentCategory,Genres=new SelectList(genre1),itemgenres=itemgenre});
      }
     

      public ViewResult addshoppingCart(int itemId,string cateGory,string itemgenre,int pageindex=1)
      {    string[] input1={"Sắp xếp","Tên","Gía"};
             List<string> genre1=new List<string>(input1);
          var selecteditem=_itemRepository.Items.FirstOrDefault(p=>p.ItemId==itemId);
          string selectedcategory=_categoryRepository.Categories.FirstOrDefault(p=>p.CategoryName.Contains(cateGory)).CategoryName;
          IEnumerable<Item> Items;
          Items = _itemRepository.Items.Where(p => p.Category.CategoryName == cateGory)
                    .OrderBy(p => p.ItemId);
          if(selecteditem != null)
          {
              _shoppingcart.AddToCart(selecteditem,1);
          }
          int count=Items.Count();
          int pagesize=3;
          return View("~/Views/Item/List.cshtml",new ItemsListViewModel{Items= new PagedList<Item>(Items.Skip((pageindex-1)*pagesize).Take(pagesize),count,pagesize,pageindex),CurrentCategory=selectedcategory,Genres=new SelectList(genre1),itemgenres=itemgenre});
      }
    }
}
