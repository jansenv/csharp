using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.Write("What is the bank's difficulty level? (1-100)");
            string bankDifficultyString = Console.ReadLine();

            List<Dictionary<string, string>> teamMembers = new List<Dictionary<string, string>>();

            while (true)
            {
                Dictionary<string, string> teamMember = new Dictionary<string, string>();

                Console.Write("Add your heist member: ");
                string memberName = Console.ReadLine();
                if (memberName == "")
                {
                    break;
                }
                teamMember.Add("name", memberName);

                Console.Write("Enter the member's skill level (0-100): ");
                string memberSkill = Console.ReadLine();
                teamMember.Add("skill level", memberSkill);

                Console.Write("Enter the member's courage factor (0.0-2.0): ");
                string memberCourage = Console.ReadLine();
                teamMember.Add("courage factor", memberCourage);

                Console.WriteLine($"Member: {memberName}; Member Skill: {memberSkill}; Member Courage: {memberCourage}");
                teamMembers.Add(teamMember);
            }

            Console.WriteLine($"Your heist team has {teamMembers.Count} members");

            // Display each member's info
            // foreach (Dictionary<string, string> member in teamMembers)
            // {
            //     foreach (KeyValuePair<string, string> i in member)
            //     {
            //         Console.WriteLine($"{i.Key}: {i.Value}");
            //     }
            // };

            Random random = new Random();

            Console.Write("How many trials you wanna do");
            string trialRuns = Console.ReadLine();
            int trialRunsNum = int.Parse(trialRuns);

            int successCount = 0;
            int failCount = 0;

            for (int i = 0; i < trialRunsNum; i++)
            {
                int sumOfMemberSkills = 0;
                int luckValue = random.Next(-10, 11);
                int bankDifficulty = int.Parse(bankDifficultyString) + luckValue;

                foreach (Dictionary<string, string> teamMember in teamMembers)
                {
                    int memberSkill = int.Parse(teamMember["skill level"]);
                    sumOfMemberSkills += memberSkill;
                }

                Console.WriteLine($"Team Skill Level: {sumOfMemberSkills}");
                Console.WriteLine($"Bank Difficulty Level: {bankDifficulty}");

                if (sumOfMemberSkills >= bankDifficulty)
                {
                    Console.WriteLine("Rob those suckers!");
                    successCount++;
                }
                else
                {
                    Console.WriteLine("Try a different establishment.");
                    failCount++;
                }
            }

            // Print a report
            Console.WriteLine($"Successful Heists: {successCount}");
            Console.WriteLine($"Unsuccessful heists: {failCount}");
        }
    }
}