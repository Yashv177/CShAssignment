using System;

namespace Assignment_2
{
    internal class Ques3
    {
        class Calculator
        {
            public int Add(int a, int b) => a + b;
            public float Add(float a, float b) => a + b;
            public double Add(double a, double b, double c) => a + b + c;
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
            Console.WriteLine("Add(float, float): " + calc.Add(3.5f, 2.5f));
            Console.WriteLine("Add(double, double, double): " + calc.Add(1.1, 2.2, 3.3));
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
