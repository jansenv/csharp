using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Dictionary<int, string> memberName = new Dictionary<int, string>();
            Dictionary<int, int> memberSkillLevel = new Dictionary<int, int>();
            Dictionary<int, decimal> memberCourage = new Dictionary<int, decimal>();
            Console.WriteLine("Add your heist member: ");
            string singleMemberName = Console.ReadLine();
            Console.WriteLine("Enter the member's skill level: ");
            string singleMemberSkillLevel = Console.ReadLine();
            Console.WriteLine("Enter the member's courage factor: ");
            string singleMemberCourage = Console.ReadLine();
            Console.WriteLine($"Member: {singleMemberName}; Member Skill: {singleMemberSkillLevel}; Member Courage: {singleMemberCourage}");
        }
    }
}
