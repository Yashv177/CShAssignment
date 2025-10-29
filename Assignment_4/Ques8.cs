// Q8. Create a delegate BillingOperation that accepts a product amount.
// • Implement four methods: ShowTotal, ApplyDiscount, AddTax, FinalBill.
// • Use delegate chaining for an item worth ₹5000.

using System;

namespace Assignment_4
{
    internal class Ques8
    {
        delegate void BillingOperation(double amount);
        static double finalAmount;

        static void ShowTotal(double amount)
        {
            finalAmount = amount;
            Console.WriteLine("Original Price: " + amount);
        }

        static void ApplyDiscount(double amount)
        {
            finalAmount -= finalAmount * 0.1;
            Console.WriteLine("After Discount: " + finalAmount);
        }

        static void AddTax(double amount)
        {
            finalAmount += finalAmount * 0.18;
            Console.WriteLine("After Tax: " + finalAmount);
        }

        static void FinalBill(double amount)
        {
            Console.WriteLine("Final Payable: " + finalAmount);
        }

        static void Main(string[] args)
        {
            BillingOperation bill = ShowTotal;
            bill += ApplyDiscount;
            bill += AddTax;
            bill += FinalBill;

            bill(5000);
            Console.WriteLine("Developed By Yash Kumar Varshney");
        }
    }
}
