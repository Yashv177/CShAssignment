using System;

namespace Assignment_1
{
    internal class Ques1
    {
        static void Main(string[] args)
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < transactions.Length; i++)
            {
                sum += transactions[i];
            }
            Console.WriteLine("Total Sum of Transactions: " + sum);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
