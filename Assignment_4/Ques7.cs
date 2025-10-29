// Q7. Create a delegate FormatText that accepts a string.
// • Implement methods to return uppercase and lowercase.
// • Demonstrate calling both through the delegate on input "Hello World".

using System;

namespace Assignment_4
{
    internal class Ques7
    {
        delegate string FormatText(string input);

        static string ToUpperCase(string input) => input.ToUpper();
        static string ToLowerCase(string input) => input.ToLower();

        static void Main(string[] args)
        {
            string text = "Hello World";
            FormatText f1 = ToUpperCase;
            FormatText f2 = ToLowerCase;

            Console.WriteLine("Upper: " + f1(text));
            Console.WriteLine("Lower: " + f2(text));
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
