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
        void PostValu(Cabin newCastomer);
        void PutById(int id, string name, double price);
        void DeleteById(int id);
    }
}
