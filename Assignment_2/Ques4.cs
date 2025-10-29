using System;

namespace Assignment_2
{
    internal class Ques4
    {
        abstract class Employee
        {
            public string Name { get; set; }
            public abstract double CalculateSalary();
        }

        class FullTimeEmployee : Employee
        {
            public double MonthlySalary { get; set; }
            public override double CalculateSalary() => MonthlySalary;
        }

        class PartTimeEmployee : Employee
        {
            public double HourlyRate { get; set; }
            public int HoursWorked { get; set; }
            public override double CalculateSalary() => HourlyRate * HoursWorked;
        }

        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee { Name = "Amit", MonthlySalary = 30000 };
            PartTimeEmployee pte = new PartTimeEmployee { Name = "Neha", HourlyRate = 200, HoursWorked = 40 };

            Console.WriteLine($"{fte.Name}'s Salary: {fte.CalculateSalary()}");
            Console.WriteLine($"{pte.Name}'s Salary: {pte.CalculateSalary()}");
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
