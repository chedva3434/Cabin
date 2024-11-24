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
        private readonly IOrderRepositores _orderRepositores;

        public OrderService(IOrderRepositores orderRepositores)
        {
            _orderRepositores = orderRepositores;
        }

        public List<Order> GetAll()
        {
            return _orderRepositores.GetList();
        }

        public Order GetById(int id)
        {
            return _orderRepositores.GetId(id);
        }

        public void PostValu(Order newCastomer)
        {
            _orderRepositores.Post(newCastomer);
        }

        public void PutById(int id,DateTime d)
        {
            _orderRepositores.Put(id,d);
        }

        public void DeleteById(int id)
        {
            _orderRepositores.Delete(id);
        }
    }
}
