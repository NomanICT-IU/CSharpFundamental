using System;

namespace PrivateAccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            account.Deposite(1000);

            var balance = account.GetBalance();
            Console.WriteLine(balance);

            Console.ReadKey();
        }
    }
}
