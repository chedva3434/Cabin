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
    public class CabinService:ICabinService
    {
        private readonly IRepositoryManager _cabinRepositores;

        public CabinService(IRepositoryManager cabinRepositores)
        {
            _cabinRepositores = cabinRepositores;
        }

        public IEnumerable<Cabin> GetAll()
        {
            return _cabinRepositores.Cabins.GetAll();
        }

        public Cabin GetById(int id)
        {
            return _cabinRepositores.Cabins.GetById(id);
        }

        public void AddValue(Cabin newCastomer)
        {
            _cabinRepositores.Cabins.Add(newCastomer);
            _cabinRepositores.Save();
        }

        public void PutValue(Cabin cabin)
        {
            _cabinRepositores.Cabins.Update(cabin);
            _cabinRepositores.Save();
        }

        public void Delete(Cabin cabin)
        {
            _cabinRepositores.Cabins.Delete(cabin);
            _cabinRepositores.Save();
        }
    }
}
