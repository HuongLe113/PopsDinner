using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
namespace Domain.Entities
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemsOfTheWeek { get; set; }
    }
}
