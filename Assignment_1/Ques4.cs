using System;

namespace Assignment_1
{
    internal class Ques4
    {
        static void Main(string[] args)
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int males = 0, females = 0;
            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                    males++;
                else
                    females++;
            }
            Console.WriteLine("Males: " + males + ", Females: " + females);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
