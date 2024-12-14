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
        private readonly IRepositoryManager _cabinRepositores;

        public CabinService(IRepositoryManager cabinRepositores)
        {
            _cabinRepositores = cabinRepositores;
        }

        public List<Cabin> GetAll()
        {
            return _cabinRepositores.Cabin.GetList();
        }

        public Cabin GetById(int id)
        {
            return _cabinRepositores.Cabin.GetId(id);
        }

        public void AddValue(Cabin newCastomer)
        {
            _cabinRepositores.Cabin.Post(newCastomer);
            _cabinRepositores.Save();
        }

        public void PutValue(int id, string name, double price)
        {
            _cabinRepositores.Cabin.Put(id, name, price);
            _cabinRepositores.Save();
        }

        public void Delete(int id)
        {
            _cabinRepositores.Cabin.Delete(id);
            _cabinRepositores.Save();
        }
    }
}
