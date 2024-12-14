using Clean.Core.Models;
using Clean.Core.Repositores;
using Clean.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class OrderService: IOrderService
    {
        private readonly IRepositoryManager _orderRepositores;

        public OrderService(IRepositoryManager orderRepositores)
        {
            _orderRepositores = orderRepositores;
        }

        public List<Order> GetAll()
        {
            return _orderRepositores.Order.GetList();
        }

        public Order GetById(int id)
        {
            return _orderRepositores.Order.GetId(id);
        }

        public void AddValue(Order newCastomer)
        {
            _orderRepositores.Order.Post(newCastomer);
            _orderRepositores.Save();
        }

        public void PutValue(int id,DateTime d)
        {
            _orderRepositores.Order.Put(id,d);
            _orderRepositores.Save();
        }

        public void Delete(int id)
        {
            _orderRepositores.Order.Delete(id);
            _orderRepositores.Save();
        }
    }
}
