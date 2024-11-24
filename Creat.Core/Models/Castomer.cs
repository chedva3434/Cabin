using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Models
{
    public class Castomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        static int count;
        public Castomer()
        {

        }
        public Castomer(string name, string phone)
        {
            id = count++;
            this.name = name;
            this.phone = phone;
        }
    }
}
