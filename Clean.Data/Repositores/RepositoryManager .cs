using Clean.Core.Models;
using Clean.Core.Repositores;
using ManagementCabin.Core.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositores
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Cabin> Cabins { get; }
        public IRepository<Castomer> Castomers { get; }
        public IRepository<Order> Orders { get; }
        public ICabinRepositores Cabin { get; }
        public ICastomerRepositores Castomer { get; }
        public IOrderRepositores Order { get; }

        public RepositoryManager(DataContext context, IRepository<Cabin> cabins, IRepository<Castomer> castomers, IRepository<Order> orders, ICabinRepositores cabin, ICastomerRepositores castomer, IOrderRepositores order)
        {
            _context = context;
            Cabins = cabins;
            Castomers = castomers;
            Orders = orders;
            Cabin = cabin;
            Castomer = castomer;
            Order = order;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
