using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_04
{
    public class Customer
    {
        private static int nextID = 100;
        public int ID { get; set; }
        public string Name { get; set; }
        public Customer(string name, Dictionary<string, double> eBal, Dictionary<string, double> iBal, Dictionary<string, double> oBal)
        {
            this.Name = name;
        }
    }
}
