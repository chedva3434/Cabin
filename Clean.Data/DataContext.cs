using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data
{
    public class DataContext
    {
        public List<Cabin> Cabins { get; set; }
        public List<Castomer> castomers { get; set; }
        public List<Order> orders { get; set; }

        public DataContext()
        {
            Cabins = new List<Cabin> { new Cabin { Id = 1, Name = "fg", Price = 500, status = false } };
            castomers = new List<Castomer> { new Castomer { id = 1 } };
            orders = new List<Order> { new Order { Id=1 } };
        }
    }
}
