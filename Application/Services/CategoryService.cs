using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using popsDiner.Application.Interface;
using popsDiner.Application.Mapping;
using popsDiner.Application.DTO;
namespace popsDiner.Application.Services
{
    public class CategoryService : ICategoryService
    {
     private readonly ICategoryRepository categoryRepository;
     public CategoryService(ICategoryRepository categoryRepository)
     {
         this.categoryRepository=categoryRepository;
     }
     public IEnumerable<Categorydto> Categories
     {
         get{
             var category=categoryRepository.Categories;
             return category.MappingcategoryDtos();
         }
     }
    }
}
