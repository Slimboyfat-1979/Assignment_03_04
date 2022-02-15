using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_04
{
    public class Investment : Account
    {
        static Dictionary<string, double> iBalances = new Dictionary<string, double>();

        public override double Balance { get; set; }

        public Investment(string name, double balance)
        {
            this.Balance = balance;
            iBalances.Add(name, Balance);
        }

        public static Dictionary<string, double> GetIBalances()
        {
            return iBalances;
        }
    }
}
