// Q4. Build a class Product with two auto-properties: Price and Discount.
// • Add a method to calculate the final price = Price – (Price * Discount/100).
// • Show result for a product with Price = 2000 and Discount = 10%.

using System;

namespace Assignment_4
{
    internal class Ques4
    {
        class Product
        {
            public double Price { get; set; }
            public double Discount { get; set; }
            public double FinalPrice() => Price - (Price * Discount / 100);
        }

        static void Main(string[] args)
        {
            Product p = new Product { Price = 2000, Discount = 10 };
            Console.WriteLine("Final Price: " + p.FinalPrice());
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
