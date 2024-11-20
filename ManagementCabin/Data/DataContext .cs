using ManagementCabin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTest
{
    public class DataContext : IDataContext
    {
        public List<Castomer> Castomers { get; set; }
        public List<Cabin> Cabins { get; set; }
        public List<Order> Orders { get; set; }
    }

}

