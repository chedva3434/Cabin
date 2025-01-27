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

        public async Task<IEnumerable<Castomer>> GetAllAsync()
        {
            return await Task.Run(()=> _castomerRepositores.Castomers.GetAll());
        }

        public async Task<Castomer> GetByIdAsync(int id)
        {
            return await Task.Run(() => _castomerRepositores.Castomers.GetById(id));
        }

        public async Task AddValueAsync( Castomer newCastomer)
        {
             _castomerRepositores.Castomers.Add(newCastomer);
             await _castomerRepositores.SaveAsync();
        }

        public async Task PutValueAsync(Castomer castomer)
        {
            _castomerRepositores.Castomers.Update(castomer);
            await _castomerRepositores.SaveAsync();
        }

        public async Task DeleteAsync(Castomer castomer)
        {
            _castomerRepositores.Castomers.Delete(castomer);
            await _castomerRepositores.SaveAsync();
        }
    }
}
