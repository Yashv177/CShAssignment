// Q9. Define a delegate ConvertTemperature that takes double input.
// • Implement methods: Celsius to Fahrenheit and Celsius to Kelvin.
// • Show result for 25°C.

using System;

namespace Assignment_4
{
    internal class Ques9
    {
        delegate void ConvertTemperature(double celsius);

        static void ToFahrenheit(double celsius)
        {
            Console.WriteLine("Fahrenheit: " + ((celsius * 9 / 5) + 32));
        }

        static void ToKelvin(double celsius)
        {
            Console.WriteLine("Kelvin: " + (celsius + 273.15));
        }

        static void Main(string[] args)
        {
            ConvertTemperature conv = ToFahrenheit;
            conv += ToKelvin;

            conv(25);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
