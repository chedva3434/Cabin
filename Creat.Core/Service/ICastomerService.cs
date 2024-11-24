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
        List<Castomer> GetAll();
        Castomer GetById(int id);
        void PostValu(Castomer newCastomer);
        void PutById(int id, string name, string phone);
        void DeleteById(int id);
    }
}
