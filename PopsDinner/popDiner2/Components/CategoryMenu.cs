using Microsoft.AspNetCore.Mvc;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
using popsDiner.Application.Mapping;
using popsDiner.Infrastructure.Persistence;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popsDiner.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryService _categoryRepository;

        public CategoryMenu(ICategoryService categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
