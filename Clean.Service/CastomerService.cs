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
    public class CastomerService: ICastomerService
    {
        private readonly IRepositoryManager _castomerRepositores;

        public CastomerService(IRepositoryManager castomerRepositores)
        {
            _castomerRepositores = castomerRepositores;
        }

        public List<Castomer> GetAll()
        {
            return _castomerRepositores.Castomer.GetList();
        }

        public Castomer GetById(int id)
        {
            return _castomerRepositores.Castomer.GetId(id);
        }

        public void AddValue( Castomer newCastomer)
        {
             _castomerRepositores.Castomer.Post(newCastomer);
            _castomerRepositores.Save();
        }

        public void PutValue(int id, string name, string phone)
        {
            _castomerRepositores.Castomer.Put(id, name, phone);
            _castomerRepositores.Save();
        }

        public void Delete(int id)
        {
            _castomerRepositores.Castomer.Delete(id);
            _castomerRepositores.Save();
        }
    }
}
