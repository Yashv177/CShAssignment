// Q3. Custom Exception — NegativeSalaryException:
// Define NegativeSalaryException : Exception.
// If entered salary < 0, throw it and handle with a clear error message.

using System;

namespace Assignment_5
{
    internal class Ques3
    {
        class NegativeSalaryException : Exception
        {
            public NegativeSalaryException() : base("Salary cannot be negative.") { }
            public NegativeSalaryException(string message) : base(message) { }
        }

        static void Main3(string[] args)
        {
            Console.Write("Enter salary: ");
            string s = Console.ReadLine();

            try
            {
                decimal salary = decimal.Parse(s);
                if (salary < 0)
                    throw new NegativeSalaryException();

                Console.WriteLine("Salary recorded: " + salary);
            }
            catch (NegativeSalaryException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: enter a numeric salary.");
            }

            ConsoleConsole.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
