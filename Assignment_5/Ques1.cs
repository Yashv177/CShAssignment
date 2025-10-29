// Q1. Handling Division by Zero:
// Read two numbers and perform division using try-catch-finally.
// Catch DivideByZeroException and display “Division by zero is not allowed.”
// In finally block display “Execution completed.”

using System;

namespace Assignment_5
{
    internal class Ques1
    {
        static void Main5(string[] args)
        {
            Console.Write("Enter numerator: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            double b = double.Parse(Console.ReadLine());

            try
            {
                double result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
                Console.WriteLine("Developed By Yash Kumar Varshney");
            }
        }
    }
}
