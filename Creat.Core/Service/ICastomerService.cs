using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Service
{
    public interface ICastomerService
    {
        Task<IEnumerable<Castomer>> GetAllAsync();
        Task<Castomer> GetByIdAsync(int id);
        Task AddValueAsync(Castomer newCastomer);
        Task PutValueAsync(Castomer castomer);
        Task DeleteAsync(Castomer castomer);
    }
}
