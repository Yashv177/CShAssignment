using System;

namespace Assignment_2
{
    internal class Ques6
    {
        class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            private double price;
            private int quantity;

            public double Price
            {
                get { return price; }
                set
                {
                    if (value >= 0)
                        price = value;
                    else
                        Console.WriteLine("Price cannot be negative.");
                }
            }

            public int Quantity
            {
                get { return quantity; }
                set
                {
                    if (value >= 0)
                        quantity = value;
                    else
                        Console.WriteLine("Quantity cannot be negative.");
                }
            }

            public void Display()
            {
                Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {price}, Qty: {quantity}");
            }
        }

        static void Main(string[] args)
        {
            Product p1 = new Product { ProductID = 1, ProductName = "Pen", Price = 10, Quantity = 100 };
            Product p2 = new Product { ProductID = 2, ProductName = "Notebook", Price = -20, Quantity = 50 };

            p1.Display();
            p2.Display();
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
