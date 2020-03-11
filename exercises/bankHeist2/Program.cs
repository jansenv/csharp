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

            Console.WriteLine($"There are {rolodex.Count} current operatives.");
            Console.WriteLine("Who would you like to add to the rolodex?");
            var newRobberName = Console.ReadLine();
            Console.WriteLine("Enter their specialty: ");
            Console.WriteLine("Hacker (Disables Alarms)");
            Console.WriteLine("Muscle (Disarms Guards)");
            Console.WriteLine("Lock Specialist (Cracks Vault)");
            var newRobberSpeciality = Console.ReadLine();
            Console.WriteLine("Enter their skill level (1-100): ");
            var newRobberSkill = Console.ReadLine();
        }
    }
}
