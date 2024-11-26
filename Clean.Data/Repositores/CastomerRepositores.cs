using Clean.Core.Models;
using Clean.Core.Repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositores
{
    public class CastomerRepositores:ICastomerRepositores
    {
        private readonly DataContext _context;

        public CastomerRepositores(DataContext context)
        {
            _context = context;
        }

        public List<Castomer> GetList()
        {
            return _context.castomers.ToList();
        }

        public Castomer GetId(int id)
        {
            var customer = _context.castomers.ToList().Find(x => x.id == id);
            return customer; 
        }

        public void Post(Castomer newCastomer)
        {
           _context.castomers.Add(newCastomer);
        }

        public void Put(int id, string name, string phone)
        {
            for (int i = 0; i < _context.castomers.ToList().Count; i++)
            {
                if (_context.castomers.ToList()[i].id == id)
                {
                    _context.castomers.ToList()[i].name = name;
                    _context.castomers.ToList()[i].phone = phone;
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _context.castomers.ToList().Count; i++)
            {
                if (_context.castomers.ToList()[i].id == id)
                {
                    _context.castomers.ToList().RemoveAt(i);
                    return;
                }

            }
        }
    }
}
