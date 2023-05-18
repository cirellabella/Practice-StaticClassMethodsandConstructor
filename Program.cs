using System.Transactions;
using System.Xml.Schema;

namespace Practice_StaticClassMethodsandConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{BusinessInfo._businessName}\n");

            List<Transaction> _transactions = new List<Transaction>();

            _transactions.Add(new Transaction("Frisbee", 5));
            _transactions.Add(new Transaction("Baseball", 3));
            _transactions.Add(new Transaction("Kite", 12));
            _transactions.Add(new Transaction("Tennis Racket", 20));
            _transactions.Add(new Transaction("T-Ball Set", 50));

            foreach (var transaction in _transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
            Console.WriteLine("\n");

            Console.WriteLine($"Tax is {BusinessInfo._taxAmount}");

            Console.WriteLine($"The total was {DailyTransactions.CalculateTotal(_transactions)}");

        }
    }
}