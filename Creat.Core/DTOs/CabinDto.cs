using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCabin.Core.DTOs
{
    public class CabinDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool status { get; set; }
        public List<Order> Orders { get; set; }
    }
}
