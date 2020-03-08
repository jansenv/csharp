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
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> Lfruits =
            from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

            // foreach (string fruit in Lfruits)
            // {
            //     Console.WriteLine($"{fruit}");
            // }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples =
            // numbers.Where(n => n % 4 == 0 || n % 6 == 0).OrderBy(n => n);
            from number in numbers
            where number % 4 == 0 || number % 6 == 0
            orderby number
            select number;

            // foreach (int multiple in fourSixMultiples)
            // {
            //     Console.WriteLine($"{multiple}");
            // }

            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend =
            // names.OrderByDescending(n => n);
            from name in names
            orderby name descending
            select name;


            // foreach (string name in descend)
            // {
            //     Console.WriteLine($"{name}");
            // };



        }
    }
}