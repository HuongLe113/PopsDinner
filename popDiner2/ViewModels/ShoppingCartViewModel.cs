using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
using popsDiner.Application.Mapping;
using popsDiner.Infrastructure.Persistence;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
namespace popsDiner.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IshoppingcartService ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
