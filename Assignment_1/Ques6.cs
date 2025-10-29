using System;

namespace Assignment_1
{
    internal class Ques6
    {
        static void Main(string[] args)
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
            }
            Console.WriteLine("Adjusted Measurements: " + string.Join(" ", measurements));
            Console.WriteLine("Developed By Yash Kumar Varshney");

        }
    }
}
