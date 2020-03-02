using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Dictionary<string, string> teamMember = new Dictionary<string, string>();

            Console.WriteLine("Add your heist member: ");
            string singleMemberName = Console.ReadLine();
            teamMember.Add("name", singleMemberName);

            Console.WriteLine("Enter the member's skill level (0-100): ");
            string singleMemberSkill = Console.ReadLine();
            teamMember.Add("skill level", singleMemberSkill);

            Console.WriteLine("Enter the member's courage factor (0.0-2.0): ");
            string singleMemberCourage = Console.ReadLine();
            teamMember.Add("courage factor", singleMemberCourage);

            Console.WriteLine($"Member: {singleMemberName}; Member Skill: {singleMemberSkill}; Member Courage: {singleMemberCourage}");
        }
    }
}
