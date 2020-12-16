using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
using popsDiner.Application.Mapping;
using popsDiner.Application.Interface;
using popsDiner.Application.DTO;
namespace popsDiner.Application.Services
{
    public class OrderService : IOrderService
    {
      private readonly IOrderRepository orderRepository;
      public OrderService(IOrderRepository orderRepository)
      {
          this.orderRepository=orderRepository;
      }
      public void CreateOrder(Orderdto order)
      {
         var order1=order.Mappingtoorder();
         orderRepository.CreateOrder(order1);
      }
    }
}
