using System;

namespace Assignment_1
{
    internal class Ques2
    {
        static void Main(string[] args)
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            float avg = sum / scores.Length;
            Console.WriteLine("Average Score: " + avg);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
