using Clean.Core.Models;
using Clean.Core.Repositores;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementCabin.Data.Repositores;

namespace Clean.Data.Repositores
{
    public class CabinRepositores : Repository<Cabin>, ICabinRepositores
    {
        public CabinRepositores(DataContext context):base(context)
        {
        }


        #region   No
        //private readonly DataContext _context;
        //public List<Cabin> GetList()
        //{
        //    return _context.Cabins.ToList();
        //}

        //public Cabin GetId(int id)
        //{
        //    var cabin = _context.Cabins.ToList().Find(x => x.Id == id);
        //    return cabin;
        //}

        //public void Post(Cabin newCastomer)
        //{
        //    _context.Cabins.Add(newCastomer);
        //}

        //public void Put(int id, string name, double price)
        //{
        //    for (int i = 0; i < _context.Cabins.ToList().Count; i++)
        //    {
        //        if (_context.Cabins.ToList()[i].Id == id)
        //        {
        //            _context.Cabins.ToList()[i].Name = name;
        //            _context.Cabins.ToList()[i].Price = price;
        //        }
        //    }
        //}

        //public void Delete(int id)
        //{
        //    for (int i = 0; i < _context.Cabins.ToList().Count; i++)
        //    {
        //        if (_context.Cabins.ToList()[i].Id == id)
        //        {
        //            _context.Cabins.ToList().RemoveAt(i);
        //            return;
        //        }

        //    }
        //}
        #endregion
    }
}
