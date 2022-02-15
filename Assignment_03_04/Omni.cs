using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_04
{
    public class Omni : Account
    {
        static Dictionary<string, double> oBalances = new Dictionary<string, double>();
        public override double Balance { get; set; }
        public Omni(string name, double balance)
        {
            this.Balance = balance;
            oBalances.Add(name, Balance);
        }

        public static Dictionary<string, double> GetOBalances()
        {
            return oBalances;
        }
    }
}
