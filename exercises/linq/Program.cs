using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class Bank
    {
        public string BankName { get; set; }
        public int HowManyMillionaires { get; set; }
    }
    public class Program
    {
        public static void Main()
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
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };

            // double HighestPrice = prices.Max();

            // Console.WriteLine(HighestPrice);

            // PARTITIONING OPERATIONS

            // List<int> wheresSquaredo = new List<int>()
            // {
            //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            // };

            // IEnumerable<int> squares = wheresSquaredo.TakeWhile(num => num % Math.Sqrt(num) != 0);

            // foreach (int sqrt in squares)
            // {
            //     Console.WriteLine(sqrt);
            // }

            /*
            Store each number in the following List until a perfect square
            is detected.

            Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            
            */

            List<Customer> customers = new List<Customer>()
            {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            /*
            Given the same customer set, display how many millionaires per bank.
            Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            Example Output:
            WF 2
            BOA 1
            FTB 1
            CITI 1
            */

            IEnumerable<Customer> millionaires =
            from customer in customers
            where customer.Balance >= 1000000.00
            select customer;

            IEnumerable<Bank> banksCount = millionaires
            .GroupBy(customer => customer.Bank)
            .Select(bank => new Bank
            {
                BankName = bank.Key,
                HowManyMillionaires = bank.Count()
            });

            foreach (Bank bank in banksCount)
            {
                Console.WriteLine($"{bank.BankName} {bank.HowManyMillionaires}");
            }

        }
    }
}