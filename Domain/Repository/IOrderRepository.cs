using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;

namespace popsDiner.Domain.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}

