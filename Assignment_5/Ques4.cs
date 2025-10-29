// Q4. Banking Scenario — InsufficientBalanceException:
// Simulate withdrawal: if withdrawal > balance, throw custom InsufficientBalanceException;
// otherwise print remaining balance.

using System;

namespace Assignment_5
{
    internal class Ques4
    {
        class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException() : base("Insufficient balance for this withdrawal.") { }
            public InsufficientBalanceException(string message) : base(message) { }
        }

        static void Main6(string[] args)
        {
            Console.Write("Enter current balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.Write("Enter amount to withdraw: ");
            decimal withdraw = decimal.Parse(Console.ReadLine());

            try
            {
                if (withdraw > balance)
                    throw new InsufficientBalanceException();

                balance -= withdraw;
                Console.WriteLine("Withdrawal successful. Remaining balance: " + balance);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Transaction failed: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: use numbers for balance and withdrawal.");
            }

            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
