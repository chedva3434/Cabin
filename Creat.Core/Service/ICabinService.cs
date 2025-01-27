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
        Task<IEnumerable<Cabin>> GetAllAsync();
        Task<Cabin> GetByIdAsync(int id);
        Task AddValueAsync(Cabin newCastomer);
        Task PutValueAsync(Cabin cabin);
        Task DeleteAsync(Cabin cabin);
    }
}
