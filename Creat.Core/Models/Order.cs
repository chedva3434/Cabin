using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Models
{
    public class Order
    {
        public int Id { get;  set; }
        public DateTime dateOfOrder { get; set; }
        public int CabinId { get; set; }
        public Cabin cabin { get; set; }
        public List<Castomer> castomer { get; set; }
        static int count;

        //public Order(DateTime dateOfOrder, int castomerId, Cabin c)
        //{
        //    Id = count++;
        //    this.dateOfOrder = dateOfOrder;
        //    //stomerId = castomerId;
        //    this.cabin = c;
        //    c.UpDateStatus();
        //}

        //public Order() { }
    }
}
