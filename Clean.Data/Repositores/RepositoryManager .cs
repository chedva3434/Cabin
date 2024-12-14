using Clean.Core.Repositores;
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
        public ICabinRepositores Cabin { get; }
        public ICastomerRepositores Castomer { get; }
        public IOrderRepositores Order { get; }

        public RepositoryManager(DataContext context, ICabinRepositores cabinRepository, ICastomerRepositores castomerRepository, IOrderRepositores orderRepository)
        {
            _context = context;
            Cabin = cabinRepository;
            Castomer = castomerRepository;
            Order = orderRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
