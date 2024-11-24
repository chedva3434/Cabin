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
        private readonly ICastomerRepositores _castomerRepositores;

        public CastomerService(ICastomerRepositores castomerRepositores)
        {
            _castomerRepositores = castomerRepositores;
        }

        public List<Castomer> GetAll()
        {
            return _castomerRepositores.GetList();
        }

        public Castomer GetById(int id)
        {
            return _castomerRepositores.GetId(id);
        }

        public void PostValu( Castomer newCastomer)
        {
             _castomerRepositores.Post(newCastomer);
        }

        public void PutById(int id, string name, string phone)
        {
            _castomerRepositores.Put(id, name, phone);
        }

        public void DeleteById(int id)
        {
            _castomerRepositores.Delete(id);
        }
    }
}
