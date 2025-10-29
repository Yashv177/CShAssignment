// Q2. Multiple Catch Blocks:
// Read console input and convert to int.
// Handle FormatException, OverflowException, and a generic Exception with distinct messages.

using System;

namespace Assignment_5
{
    internal class Ques2
    {
        static void Main4(string[] args)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            try
            {
                int value = int.Parse(input);
                Console.WriteLine("You entered: " + value);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format: please enter digits only.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow: number is too large or too small for Int32.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
