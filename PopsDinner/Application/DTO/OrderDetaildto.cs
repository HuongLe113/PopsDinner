﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
namespace popsDiner.Application.DTO
{
    public class OrderDetaildto
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
         public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }

    }
}