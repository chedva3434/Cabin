using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Models
{
    public class Castomer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        static int count;
        public Order order { get; set; }
        //public Cabin cabin { get; set; }
        //public Castomer()
        //{

        //}
        //public Castomer(string name, string phone)
        //{
        //    Id = count++;
        //    this.name = name;
        //    this.phone = phone;
        //}
    }
}
