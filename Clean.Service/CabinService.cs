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
    public class CabinService:ICabinService
    {
        private readonly ICabinRepositores _cabinRepositores;

        public CabinService(ICabinRepositores cabinRepositores)
        {
            _cabinRepositores = cabinRepositores;
        }

        public List<Cabin> GetAll()
        {
            return _cabinRepositores.GetList();
        }

        public Cabin GetById(int id)
        {
            return _cabinRepositores.GetId(id);
        }

        public void PostValu(Cabin newCastomer)
        {
            _cabinRepositores.Post(newCastomer);
        }

        public void PutById(int id, string name, double price)
        {
            _cabinRepositores.Put(id, name, price);
        }

        public void DeleteById(int id)
        {
            _cabinRepositores.Delete(id);
        }
    }
}
