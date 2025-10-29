// Q2. Design a class Student with a property Age.
// • Ensure that only values between 5 and 25 are allowed.
// • If invalid age is set, default to 18.
// • Show the behavior for age 4, 20, and 30.

using System;

namespace Assignment_4
{
    internal class Ques2
    {
        class Student
        {
            private int age;
            public int Age
            {
                get { return age; }
                set
                {
                    if (value >= 5 && value <= 25) age = value;
                    else age = 18;
                }
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student { Age = 4 };
            Student s2 = new Student { Age = 20 };
            Student s3 = new Student { Age = 30 };

            Console.WriteLine("Age1: " + s1.Age);
            Console.WriteLine("Age2: " + s2.Age);
            Console.WriteLine("Age3: " + s3.Age);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
