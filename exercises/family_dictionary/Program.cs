using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>()
            {
                {"name", "Z"},
                {"age", "28"}
            });

            myFamily.Add("mother", new Dictionary<string, string>() {
                {"name", "Karen"},
                {"age", "52"}
            });

            myFamily.Add("father", new Dictionary<string, string>() {
                {"name", "Sterling"},
                {"age", "55"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }
        }
    }
}
