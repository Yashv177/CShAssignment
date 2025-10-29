using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    //Q1:---------------------------------------------------------------------------
    //internal class Calculator
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] transactions = { 200, -150, 340, 500, -100 };
    //        int sum = 0;
    //        for (int i = 0; i < transactions.Length; i++)
    //        {
    //            sum = sum + transactions[i];
    //        }
    //        Console.WriteLine("Sum of transactions: " + sum);
    //    }
    //}


    //Q2:---------------------------------------------------------------------------
    //internal class ClassAnalytics
    //{
    //    static void Main(string[] args)
    //    {
    //        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
    //        float sum = 0;
    //        foreach (float score in scores)
    //        {
    //            sum = sum + score;
    //        }
    //        float average = sum / scores.Length;
    //        Console.WriteLine("Average score: " + average);
    //    }
    //}

    //Q3:---------------------------------------------------------------------------
    //internal class InventorySystem
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] prices = { 1500, 2300, 999, 3200, 1750 };
    //        int mostExpensive = prices[0];
    //        for (int i = 1; i < prices.Length; i++)
    //        {
    //            if (prices[i] > mostExpensive)
    //            {
    //                mostExpensive = prices[i];
    //            }
    //        }
    //        Console.WriteLine("Largest: " + mostExpensive);
    //    }
    //}

    //Q4:---------------------------------------------------------------------------
    //internal class SurveyReport
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] participantCodes = { 102, 215, 324, 453, 536 };
    //        int maleCount = 0;
    //        int femaleCount = 0;
    //        foreach (int code in participantCodes)
    //        {
    //            if (code % 2 == 0)
    //            {
    //                maleCount = maleCount + 1;
    //            }
    //            else
    //            {
    //                femaleCount = femaleCount + 1;
    //            }
    //        }
    //        Console.WriteLine("males: " + maleCount);
    //        Console.WriteLine("females: " + femaleCount);
    //    }
    //}

    //Q5:---------------------------------------------------------------------------
    //internal class SearchHistoryApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] searchHistory = { 101, 202, 303, 404, 505 };
    //        Console.WriteLine("reverse order:");
    //        for (int i = searchHistory.Length - 1; i >= 0; i--)
    //        {
    //            Console.WriteLine(searchHistory[i]);
    //        }
    //    }
    //}


    //Q6:---------------------------------------------------------------------------
    //internal class MeasurementAdjuster
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] measurements = { 2, 4, 6, 8 };
    //        int factor = 3;

    //        Console.WriteLine("Adjusted measurements:");
    //        for (int i = 0; i < measurements.Length; i++)
    //        {
    //            measurements[i] = measurements[i] * factor;
    //            Console.WriteLine(measurements[i]);
    //        }
    //    }
    //}


    //Q7:---------------------------------------------------------------------------
    //internal class LibrarySearch
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] bookCodes = { 101, 203, 304, 405, 506 };
    //        int searchCode = 304;
    //        int foundIndex = -1;
    //        for (int i = 0; i < bookCodes.Length; i++)
    //        { 
    //            if (bookCodes[i] == searchCode)
    //            {
    //                foundIndex = i;
    //                break;
    //            }
    //        }
    //        if (foundIndex != -1)
    //        {
    //            Console.WriteLine("found at: " + foundIndex);
    //        }
    //        else
    //        {
    //            Console.WriteLine("not found");
    //        }
    //    }
    //}


    //Q8:---------------------------------------------------------------------------
    //internal class StudentGrades
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] grades = {56, 78, 89, 45, 67};
    //        Array.Sort(grades);
    //        int secondSmallest = grades[1];
    //        Console.WriteLine("smallest: " + secondSmallest);
    //    }
    //}


    //Q9:---------------------------------------------------------------------------
    //internal class RemoveDuplicates
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] ids = { 102, 215, 102, 324, 215 };
    //        HashSet<int> uniqueIds = new HashSet<int>();
    //        foreach (int id in ids)
    //        { 
    //            uniqueIds.Add(id);
    //        }
    //        foreach (int id in uniqueIds)
    //        {
    //            Console.WriteLine(id);
    //        }
    //    }
    //}


    //Q10;---------------------------------------------------------------------------
    internal class CommonElementsFinder
    {
        static void Main(string[] args)
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };

            Console.WriteLine("Common elements:");
            for (int i = 0; i < dataset1.Length; i++)
            {
                for (int j = 0; j < dataset2.Length; j++)
                {
                    if (dataset1[i] == dataset2[j])
                    {
                        Console.WriteLine(dataset1[i]);
                    }
                }
            }
        }
    }
}
