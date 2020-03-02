﻿using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            List<Dictionary<string, string>> teamMembers = new List<Dictionary<string, string>>();

            while (true)
            {
                Dictionary<string, string> teamMember = new Dictionary<string, string>();

                Console.WriteLine("Add your heist member: ");
                string memberName = Console.ReadLine();
                if (memberName == "")
                {
                    break;
                }
                teamMember.Add("name", memberName);

                Console.WriteLine("Enter the member's skill level (0-100): ");
                string memberSkill = Console.ReadLine();
                teamMember.Add("skill level", memberSkill);

                Console.WriteLine("Enter the member's courage factor (0.0-2.0): ");
                string memberCourage = Console.ReadLine();
                teamMember.Add("courage factor", memberCourage);

                Console.WriteLine($"Member: {memberName}; Member Skill: {memberSkill}; Member Courage: {memberCourage}");
                teamMembers.Add(teamMember);
            }

            Console.WriteLine($"Your heist team has {teamMembers.Count} members");

            int bankDifficulty = 100;

            // Display each member's info
            // foreach (Dictionary<string, string> member in teamMembers)
            // {
            //     foreach (KeyValuePair<string, string> i in member)
            //     {
            //         Console.WriteLine($"{i.Key}: {i.Value}");
            //     }
            // };

        }
    }
}
