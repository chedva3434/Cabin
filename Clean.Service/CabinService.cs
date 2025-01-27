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

        public async Task<IEnumerable<Cabin>> GetAllAsync()
        {
            return await Task.Run(() => _cabinRepositores.Cabins.GetAll());  
        }

        public async Task<Cabin> GetByIdAsync(int id)
        {
            return await Task.Run(() => _cabinRepositores.Cabins.GetById(id));  

        }

        public async Task AddValueAsync(Cabin newCastomer)
        {
            _cabinRepositores.Cabins.Add(newCastomer);
           await _cabinRepositores.SaveAsync();
        }

        public async Task PutValueAsync(Cabin cabin)
        {
           _cabinRepositores.Cabins.Update(cabin);
           await _cabinRepositores.SaveAsync();
        }

        public async Task DeleteAsync(Cabin cabin)
        {
            _cabinRepositores.Cabins.Delete(cabin);
            await _cabinRepositores.SaveAsync();
        }
    }
}
