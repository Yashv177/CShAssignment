using System;

namespace Assignment_2
{
    internal class Ques2
    {
        class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }

        class Truck : Vehicle
        {
            public void DisplayDetails()
            {
                Console.WriteLine($"Truck: {Make}, {Model}, {Year}");
            }
        }

        class Bus : Vehicle
        {
            public void DisplayDetails()
            {
                Console.WriteLine($"Bus: {Make}, {Model}, {Year}");
            }
        }

        static void Main(string[] args)
        {
            Truck truck = new Truck { Make = "Tata", Model = "407", Year = 2020 };
            Bus bus = new Bus { Make = "Volvo", Model = "9400", Year = 2022 };

            truck.DisplayDetails();
            bus.DisplayDetails();
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
