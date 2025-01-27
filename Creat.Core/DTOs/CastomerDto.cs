using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCabin.Core.DTOs
{
    public class CastomerDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public Order order { get; set; }
    }
}
