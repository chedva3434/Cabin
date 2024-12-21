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
        IEnumerable<Castomer> GetAll();
        Castomer GetById(int id);
        void AddValue(Castomer newCastomer);
        void PutValue(Castomer castomer);
        void Delete(Castomer castomer);
    }
}
