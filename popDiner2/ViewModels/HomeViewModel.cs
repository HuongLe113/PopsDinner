using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using popsDiner.Application.DTO;
using popsDiner.Application.Interface;
using popsDiner.Application.Services;
namespace popsDiner.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Itemdto> ItemsOfTheWeek { get; set; }
    }
}
