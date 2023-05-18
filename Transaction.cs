using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_StaticClassMethodsandConstructor
{
    internal class Transaction
    {
        //fields
        DateTime _now = DateTime.Now;
        string _name;
        double _amount;

        //constructor
        public Transaction(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }

        //properties
        public string Name { get => _name; set => _name = value; }
        public double Amount { get => _amount; set => _amount = value; }

        public override string ToString()
        {
            return $" {Name} {_now.ToShortDateString()} {Amount:c2}";
        }
    }
}
