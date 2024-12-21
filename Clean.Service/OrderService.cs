using Clean.Core.Models;
using Clean.Core.Repositores;
using Clean.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCabin.Service
{
    public class OrderService: IOrderService
    {
        private readonly IRepositoryManager _orderRepositores;

        public OrderService(IRepositoryManager orderRepositores)
        {
            _orderRepositores = orderRepositores;
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepositores.Orders.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderRepositores.Orders.GetById(id);
        }

        public void AddValue(Order newCastomer)
        {
            _orderRepositores.Orders.Add(newCastomer);
            _orderRepositores.Save();
        }

        public void PutValue(Order order)
        {
            _orderRepositores.Orders.Update(order);
            _orderRepositores.Save();
        }

        public void Delete(Order order)
        {
            _orderRepositores.Orders.Delete(order);
            _orderRepositores.Save();
        }
    }
}
