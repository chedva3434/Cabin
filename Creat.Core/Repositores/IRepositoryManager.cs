using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositores
{
    public interface IRepositoryManager
    {

        ICabinRepositores Cabin { get; }
        ICastomerRepositores Castomer { get; }
        IOrderRepositores Order { get; }

        void Save();
    }
}
