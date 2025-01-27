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

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await Task.Run(()=> _orderRepositores.Orders.GetAll());
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await Task.Run(() => _orderRepositores.Orders.GetById(id));
        }

        public async Task AddValueAsync(Order newCastomer)
        {
            _orderRepositores.Orders.Add(newCastomer);
            await _orderRepositores.SaveAsync();
        }

        public async Task PutValueAsync(Order order)
        {
            _orderRepositores.Orders.Update(order);
            await _orderRepositores.SaveAsync();
        }

        public async Task DeleteAsync(Order order)
        {
            _orderRepositores.Orders.Delete(order);
            await _orderRepositores.SaveAsync();
        }
    }
}
