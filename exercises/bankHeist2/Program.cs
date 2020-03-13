using System;
using System.Collections.Generic;
using System.Linq;

namespace bankHeist2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create rolodex of robbers
            List<IRobber> rolodex = new List<IRobber>();

            //Instantiate some robbers
            Hacker Audrey = new Hacker()
            {
                Name = "Audrey Borgra",
                Title = "Hacker",
                SkillLevel = 84,
                PercentageCut = 14
            };
            Hacker Willy = new Hacker()
            {
                Name = "Willy Metcalf",
                Title = "Hacker",
                SkillLevel = 87,
                PercentageCut = 15
            };
            LockSpecialist Holden = new LockSpecialist()
            {
                Name = "Holden Parker",
                Title = "Lock Specialist",
                SkillLevel = 69,
                PercentageCut = 4
            };
            LockSpecialist Kevin = new LockSpecialist()
            {
                Name = "Kevin Penny",
                Title = "Lock Specialist",
                SkillLevel = 74,
                PercentageCut = 6
            };
            Muscle Aja = new Muscle()
            {
                Name = "Aja Washington",
                Title = "Muscle",
                SkillLevel = 90,
                PercentageCut = 11
            };
            Muscle Garrett = new Muscle()
            {
                Name = "Garrett Freshwater",
                Title = "Muscle",
                SkillLevel = 65
            };

            //Add robbers to the rolodex
            rolodex.Add(Audrey);
            rolodex.Add(Willy);
            rolodex.Add(Holden);
            rolodex.Add(Kevin);
            rolodex.Add(Aja);
            rolodex.Add(Garrett);


            while (true)
            {
                Console.WriteLine($"There are {rolodex.Count} current operatives.");
                Console.WriteLine("\nWho would you like to add to the rolodex?");
                string newRobberName = Console.ReadLine();
                if (newRobberName == "")
                {
                    break;
                }
                Console.WriteLine("Enter their specialty: ");
                Console.WriteLine("\nHacker (Disables Alarms)");
                Console.WriteLine("Muscle (Disarms Guards)");
                Console.WriteLine("Lock Specialist (Cracks Vault)");
                string newRobberSpeciality = Console.ReadLine();
                Console.WriteLine("\nEnter their skill level (1-100): ");
                int newRobberSkill = int.Parse(Console.ReadLine());
                Console.WriteLine("\nWhat percentage of the cut should they get?");
                int newRobberCut = int.Parse(Console.ReadLine());

                if (newRobberSpeciality == "Hacker")
                {
                    Hacker hacker = new Hacker()
                    {
                        Name = newRobberName,
                        Title = newRobberSpeciality,
                        SkillLevel = newRobberSkill,
                        PercentageCut = newRobberCut,
                    };

                    rolodex.Add(hacker);
                }
                else if (newRobberSpeciality == "Muscle")
                {
                    Muscle muscle = new Muscle()
                    {
                        Name = newRobberName,
                        Title = newRobberSpeciality,
                        SkillLevel = newRobberSkill,
                        PercentageCut = newRobberCut,
                    };

                    rolodex.Add(muscle);
                }
                else if (newRobberSpeciality == "Lock Specialist")
                {
                    LockSpecialist lockSpecialist = new LockSpecialist()
                    {
                        Name = newRobberName,
                        Title = newRobberSpeciality,
                        SkillLevel = newRobberSkill,
                        PercentageCut = newRobberCut,
                    };

                    rolodex.Add(lockSpecialist);
                }

                Random random = new Random();
                Bank TestBank = new Bank();
                Random randy = new Random();
                var AlarmScore = randy.Next(0, 101);
                var VaultScore = randy.Next(0, 101);
                var SecurityGuardScore = randy.Next(0, 101);
                var CashOnHand = randy.Next(50000, 1000001);

                Dictionary<string, int> SecurityScores = new Dictionary<string, int>();
                SecurityScores.Add("Alarm", AlarmScore);
                SecurityScores.Add("Vault", VaultScore);
                SecurityScores.Add("Security Guard", SecurityGuardScore);
                var OrderedScores = SecurityScores.OrderBy(score => score.Value);
                var mostSecure = OrderedScores.Last();
                var leastSecure = OrderedScores.First();

                Console.WriteLine("-----------RECON REPORT----------");

                Console.WriteLine($"Most secure: {mostSecure.Key}");
                Console.WriteLine($"Least secure: {leastSecure.Key}");

                foreach (var crewMember in rolodex)
                {
                    Console.WriteLine($"\nCrewmember Index: {rolodex.IndexOf(crewMember)}");
                    Console.WriteLine($"Name: {crewMember.Name}");
                    Console.WriteLine($"Title: {crewMember.Title}");
                    Console.WriteLine($"Skill: {crewMember.SkillLevel}");
                    Console.WriteLine($"Percentage cut: {crewMember.PercentageCut}");
                }

                Console.WriteLine("-------------------------");

                List<IRobber> crew = new List<IRobber>();

                while (true)
                {
                    Console.WriteLine("Enter the index # of the crew member you want");
                    string selectedCrewMember = Console.ReadLine();
                    if (selectedCrewMember == "")
                    {
                        break;
                    }
                    foreach (var crewMember in rolodex)
                    {
                        if (int.Parse(selectedCrewMember) == rolodex.IndexOf(crewMember))
                        {
                            crew.Add(crewMember);
                        }
                    }
                    Console.WriteLine("Your selected crew:\n");
                    foreach (var crewMate in crew)
                    {
                        Console.WriteLine($"Crewmember Index: {rolodex.IndexOf(crewMate)}");
                        Console.WriteLine($"Name: {crewMate.Name}");
                        Console.WriteLine($"Title: {crewMate.Title}");
                        Console.WriteLine($"Skill: {crewMate.SkillLevel}");
                        Console.WriteLine($"Percentage cut: {crewMate.PercentageCut}\n");
                    }
                }
            }
        }
    }
}
