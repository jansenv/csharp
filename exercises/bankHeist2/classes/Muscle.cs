using System;

namespace bankHeist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is beating down the security guards. Decreased security {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has incapacitated the guards!");
            }
            else
            {
                Console.WriteLine($" ");
            }
        }

    }
}
