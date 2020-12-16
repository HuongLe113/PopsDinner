using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Application.DTO;
namespace popsDiner.Application.Interface
{
    public interface IOrderService
    {
        void CreateOrder(Orderdto order);
    }
}

