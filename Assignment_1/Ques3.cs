using System;

namespace Assignment_1
{
    internal class Ques3
    {
        static void Main(string[] args)
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int max = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > max)
                    max = prices[i];
            }
            Console.WriteLine("Most Expensive Item: " + max);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
