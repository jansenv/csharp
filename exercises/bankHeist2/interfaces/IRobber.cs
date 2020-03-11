using System;

namespace bankHeist2
{
    public interface IRobber
    {
        string Name { get; set; }
        string Title { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill(Bank bank);
    }
}
