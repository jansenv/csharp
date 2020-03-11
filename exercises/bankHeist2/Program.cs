using System;
using System.Collections.Generic;

namespace bankHeist2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create rolodex of robbers
            List<IRobber> rolodex = new List<IRobber>();

            //Instantiate some robbers
            Hacker Audrey = new Hacker();
            Hacker Willy = new Hacker();
            LockSpecialist Holden = new LockSpecialist();
            LockSpecialist Kevin = new LockSpecialist();
            Muscle Aja = new Muscle();
            Muscle Garrett = new Muscle();

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
                Console.WriteLine("Who would you like to add to the rolodex?");
                string newRobberName = Console.ReadLine();
                if (newRobberName == "")
                {
                    break;
                }
                Console.WriteLine("Enter their specialty: ");
                Console.WriteLine("Hacker (Disables Alarms)");
                Console.WriteLine("Muscle (Disarms Guards)");
                Console.WriteLine("Lock Specialist (Cracks Vault)");
                string newRobberSpeciality = Console.ReadLine();
                Console.WriteLine("Enter their skill level (1-100): ");
                int newRobberSkill = int.Parse(Console.ReadLine());
                Console.WriteLine("What percentage of the cut should they get?");
                int newRobberCut = int.Parse(Console.ReadLine());

                if (newRobberSpeciality == "Hacker")
                {
                    Hacker hacker = new Hacker()
                    {
                        Name = newRobberName,
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
                        SkillLevel = newRobberSkill,
                        PercentageCut = newRobberCut,
                    };

                    rolodex.Add(lockSpecialist);
                }
            }
        }
    }
}
