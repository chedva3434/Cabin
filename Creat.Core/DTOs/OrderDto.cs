using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCabin.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime dateOfOrder { get; set; }
        public int CabinId { get; set; }
        public Cabin cabin { get; set; }
    }
}
