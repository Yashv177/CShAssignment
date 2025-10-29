// Q5. Create a Student class with marks property.
// If marks are not between 0 and 100, show "Invalid Marks" message using exception handling.

using System;

namespace Assignment_5
{
    internal class Ques5
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter marks (0–100): ");
                int marks = int.Parse(Console.ReadLine());

                if (marks < 0 || marks > 100)
                    throw new Exception("Invalid Marks! Marks should be between 0 and 100.");

                Console.WriteLine("Marks entered: " + marks);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
