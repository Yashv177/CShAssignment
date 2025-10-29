using System;

namespace Assignment_1
{
    internal class Ques5
    {
        static void Main(string[] args)
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            Console.WriteLine("Search History in Reverse:");
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.Write(searchHistory[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
