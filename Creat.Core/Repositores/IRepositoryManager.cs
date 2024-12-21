using Clean.Core.Models;
using ManagementCabin.Core.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositores
{
    public interface IRepositoryManager
    {      
        public IRepository<Cabin> Cabins { get; }
        public IRepository<Castomer> Castomers { get; }
        public IRepository<Order> Orders { get; }
        public ICabinRepositores Cabin { get; }
        public ICastomerRepositores Castomer { get; }
        public IOrderRepositores Order { get; }
        void Save();
    }
}
