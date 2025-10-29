// Q3. Create a class Employee with:
// • A private field basicSalary.
// • A read-only property TotalSalary that calculates salary with 20% bonus.
// • Demonstrate setting basicSalary = 30000 and display TotalSalary.

using System;

namespace Assignment_4
{
    internal class Ques3
    {
        class Employee
        {
            private double basicSalary;
            public void SetSalary(double salary) => basicSalary = salary;
            public double TotalSalary => basicSalary + (0.2 * basicSalary);
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetSalary(30000);
            Console.WriteLine("Total Salary: " + emp.TotalSalary);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
