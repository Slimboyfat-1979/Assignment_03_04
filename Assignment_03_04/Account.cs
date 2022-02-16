using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_04
{
    public abstract class Account
    {
        private static int nextID = 1000;
        public int ID { get; set; }
        public abstract double Balance { get; set; }
        public Account()
        {
            ++nextID;
            ID = nextID;
        }
    }
}
