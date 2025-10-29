// Q1. Create a class BankAccount with a property Balance.
// • The property should allow deposit but not allow direct withdrawal (only decrease balance via a method).
// • Demonstrate depositing 1000 and withdrawing 500 using the property and method.

using System;

namespace Assignment_4
{
    internal class Ques1
    {
        class BankAccount
        {
            private double balance;

            public double Balance
            {
                get { return balance; }
                set { balance += value; }
            }

            public void Withdraw(double amount)
            {
                if (amount <= balance) balance -= amount;
                else Console.WriteLine("Insufficient balance");
            }
        }

        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Balance = 1000;
            acc.Withdraw(500);
            Console.WriteLine("Final Balance: " + acc.Balance);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
