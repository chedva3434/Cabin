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
        IEnumerable<Cabin> GetAll();
        Cabin GetById(int id);
        void AddValue(Cabin newCastomer);
        void PutValue(Cabin cabin);
        void Delete(Cabin cabin);
    }
}
