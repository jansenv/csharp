using System;

namespace bankHeist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is picking the locks. Decreased security {SkillLevel} points.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the vaults!");
            }
            else
            {
                Console.WriteLine($" ");
            }
        }

    }
}
