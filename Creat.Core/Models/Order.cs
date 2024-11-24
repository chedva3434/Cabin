using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Models
{
    public class Order
    {
        public int Id { get;  set; }
        public DateTime dateOfOrder { get; set; }
        public int CastomerId { get; set; }
        public Cabin cabin { get; set; }
        static int count;

        public Order(DateTime dateOfOrder, int castomerId, Cabin c)
        {
            Id = count++;
            this.dateOfOrder = dateOfOrder;
            CastomerId = castomerId;
            this.cabin = c;
            c.UpDateStatus();
        }

        public Order() { }
    }
}
