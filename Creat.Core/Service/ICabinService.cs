using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Service
{
    public interface ICabinService
    {
        List<Cabin> GetAll();
        Cabin GetById(int id);
        void AddValue(Cabin newCastomer);
        void PutValue(int id, string name, double price);
        void Delete(int id);
    }
}
