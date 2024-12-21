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
    public class CastomerService: ICastomerService
    {
        private readonly IRepositoryManager _castomerRepositores;

        public CastomerService(IRepositoryManager castomerRepositores)
        {
            _castomerRepositores = castomerRepositores;
        }

        public IEnumerable<Castomer> GetAll()
        {
            return _castomerRepositores.Castomers.GetAll();
        }

        public Castomer GetById(int id)
        {
            return _castomerRepositores.Castomers.GetById(id);
        }

        public void AddValue( Castomer newCastomer)
        {
             _castomerRepositores.Castomers.Add(newCastomer);
            _castomerRepositores.Save();
        }

        public void PutValue(Castomer castomer)
        {
            _castomerRepositores.Castomers.Update(castomer);
            _castomerRepositores.Save();
        }

        public void Delete(Castomer castomer)
        {
            _castomerRepositores.Castomers.Delete(castomer);
            _castomerRepositores.Save();
        }
    }
}
