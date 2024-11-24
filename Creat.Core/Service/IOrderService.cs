using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Service
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        void PostValu(Order newCastomer);
        void PutById(int id,DateTime d);
        void DeleteById(int id);
    }
}
