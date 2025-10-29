// Q6. Define a delegate Operation for performing arithmetic operations.
// • Implement methods Add and Subtract.
// • Ask the user for two numbers and apply both operations using the delegate.

using System;

namespace Assignment_4
{
    internal class Ques6
    {
        delegate int Operation(int a, int b);

        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            Operation op1 = Add;
            Operation op2 = Subtract;

            Console.WriteLine("Addition: " + op1(x, y));
            Console.WriteLine("Subtraction: " + op2(x, y));
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
