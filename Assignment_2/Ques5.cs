using System;

namespace Assignment_2
{
    internal class Ques5
    {
        class Student
        {
            string name;
            int rollNo;
            int marks;

            public Student()
            {
                name = "Unknown";
                rollNo = 0;
                marks = 0;
            }

            public Student(string name, int rollNo)
            {
                this.name = name;
                this.rollNo = rollNo;
                this.marks = 0;
            }

            public Student(string name, int rollNo, int marks)
            {
                this.name = name;
                this.rollNo = rollNo;
                this.marks = marks;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {name}, Roll: {rollNo}, Marks: {marks}");
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Yash", 53);
            Student s3 = new Student("Raj", 50, 85);

            s1.Display();
            s2.Display();
            s3.Display();
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
