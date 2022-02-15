using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_04
{
    public class Everyday : Account
    {
        Controller control = Home.GetController();

        static Dictionary<string, double> eBalances = new Dictionary<string, double>();
        public override double Balance { get; set; }
        public Everyday(string name, double balance)
        {
            this.Balance = balance;
            eBalances.Add(name, Balance);
        }

        public static Dictionary<string, double> GetEBalances()
        {
            return eBalances;
        }
    }
}
