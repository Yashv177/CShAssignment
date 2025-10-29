// Q5. Create a Car class with a property Speed.
// • Speed should not exceed 180 km/h; if it exceeds, reset to 180.
// • Write code to set speed = 150, then 200, and display the final speed.

using System;

namespace Assignment_4
{
    internal class Ques5
    {
        class Car
        {
            private int speed;
            public int Speed
            {
                get { return speed; }
                set
                {
                    if (value > 180) speed = 180;
                    else speed = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 150;
            car.Speed = 200;
            Console.WriteLine("Final Speed: " + car.Speed);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
