using Clean.Core.Models;
using Clean.Core.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositores
{
    public class OrderRepositores : IOrderRepositores
    {
        private readonly DataContext _context;

        public OrderRepositores(DataContext context)
        {
            _context = context;
        }

        public List<Order> GetList()
        {
            return _context.orders;
        }

        public Order GetId(int id)
        {
            var order = _context.orders.Find(x => x.Id == id);
            return order;
        }

        public void Post(Order newOrder)
        {
            _context.orders.Add(newOrder);
        }

        public void Put(int id, DateTime d)
        {
            for (int i = 0; i < _context.orders.Count; i++)
            {
                if (_context.orders[i].Id == id)
                {
                   _context.orders[i].dateOfOrder = d;
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _context.orders.Count; i++)
            {
                if (_context.orders[i].Id == id)
                {
                    _context.orders.RemoveAt(i);
                }
            }
        }
    }
}
