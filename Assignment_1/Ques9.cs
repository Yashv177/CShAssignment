using System;
using System.Collections.Generic;

namespace Assignment_1
{
    internal class Ques9
    {
        static void Main(string[] args)
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            HashSet<int> uniqueIds = new HashSet<int>(ids);
            Console.WriteLine("Unique IDs: " + string.Join(" ", uniqueIds));
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
