using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // RESTRICTION / FILTERING OPERATIONS

            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // IEnumerable<string> Lfruits =
            // from fruit in fruits
            // where fruit.StartsWith("L")
            // select fruit;

            // foreach (string fruit in Lfruits)
            // {
            //     Console.WriteLine($"{fruit}");
            // }

            // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // IEnumerable<int> fourSixMultiples =
            // // numbers.Where(n => n % 4 == 0 || n % 6 == 0).OrderBy(n => n);
            // from number in numbers
            // where number % 4 == 0 || number % 6 == 0
            // orderby number
            // select number;

            // foreach (int multiple in fourSixMultiples)
            // {
            //     Console.WriteLine($"{multiple}");
            // }

            // ORDERING OPERATIONS

            // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // IEnumerable<string> descend =
            // // names.OrderByDescending(n => n);
            // from name in names
            // orderby name descending
            // select name;

            // foreach (string name in descend)
            // {
            //     Console.WriteLine($"{name}");
            // };

            // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // IEnumerable<int> ascend =
            // from number in numbers
            // orderby number
            // select number;

            // foreach (int number in ascend)
            // {
            //     Console.WriteLine($"{number}");
            // }

            // AGGREGATE OPERATIONS

            // Output how many numbers are in this list
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // var count = numbers.Count();

            // Console.WriteLine(count);

            // How much money have we made?
            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };

            // double sumOfPurchases = purchases.Sum();

            // Console.WriteLine($"${sumOfPurchases}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double HighestPrice = prices.Max();

            Console.WriteLine(HighestPrice);

        }
    }
}