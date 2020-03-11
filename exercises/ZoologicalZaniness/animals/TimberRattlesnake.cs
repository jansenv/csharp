using System;

namespace ZoologicalZaniness
{
    public class TimberRattlesnake : IMoving
    {
        public int MaximumDepth { get; } = 100;
        public int MaximumSpeed { get; } = 10;

        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
        public void Move()
        {
            Console.WriteLine("That boi is movin'");
        }
    }
}