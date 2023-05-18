using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_StaticClassMethodsandConstructor
{
    internal static class DailyTransactions
    {
        //static fields
        static List<Transaction> _transactions;

        //static constructor
        static DailyTransactions()
        {
            _transactions = new List<Transaction>();
        }

        //method
        internal static void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        internal static double CalculateTotal(List<Transaction> _transactions)
        {
            double total = 0;
            double tax = 0.08;
            foreach (var transaction in _transactions)
            {
                total += transaction.Amount + (transaction.Amount * tax);
            }
            return total;
        }

        public static void DisplayAllInfo(List<Transaction> _transactions)
        {
            foreach (var transaction in _transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }
    }
}
