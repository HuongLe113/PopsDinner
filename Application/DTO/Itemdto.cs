using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
namespace popsDiner.Application.DTO
{
    public class Itemdto
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string shortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool isItemOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }

    }
}
