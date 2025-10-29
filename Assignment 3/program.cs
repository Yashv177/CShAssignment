using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: ${Salary:F2}");
    }
}

class Program
{
    public static void Main()
    {
        Employee emp = new Employee("Yash Varshney", 30, 75000.00);
        emp.DisplayDetails();
    }
}
