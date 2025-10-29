using System;
using System.Collections.Generic;

namespace Assignment_1
{
    internal class Ques10
    {
        static void Main(string[] args)
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            List<int> common = new List<int>();
            for (int i = 0; i < dataset1.Length; i++)
            {
                for (int j = 0; j < dataset2.Length; j++)
                {
                    if (dataset1[i] == dataset2[j])
                        common.Add(dataset1[i]);
                }
            }
            Console.WriteLine("Common Elements: " + string.Join(" ", common));
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
