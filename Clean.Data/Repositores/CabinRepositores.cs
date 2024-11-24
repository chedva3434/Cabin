using Clean.Core.Models;
using Clean.Core.Repositores;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositores
{
    public class CabinRepositores : ICabinRepositores
    {
        private readonly DataContext _context;

        public CabinRepositores(DataContext context)
        {
            _context = context;
        }

        public List<Cabin> GetList()
        {
            return _context.Cabins;
        }

        public Cabin GetId(int id)
        {
            var cabin = _context.Cabins.Find(x => x.Id == id);
            return cabin;
        }

        public void Post(Cabin newCastomer)
        {
            _context.Cabins.Add(newCastomer);
        }

        public void Put(int id, string name, double price)
        {
            for (int i = 0; i < _context.Cabins.Count; i++)
            {
                if (_context.Cabins[i].Id == id)
                {
                    _context.Cabins[i].Name = name;
                    _context.Cabins[i].Price = price;
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _context.Cabins.Count; i++)
            {
                if (_context.Cabins[i].Id == id)
                {
                    _context.Cabins.RemoveAt(i);
                    return;
                }

            }
        }
    }
}
