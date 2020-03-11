using System;

namespace ZoologicalZaniness
{
    public class Ant : IWalking, IMoving, IDigging
    {
        public int MaximumDepth { get; } = 1;
        public int MaximumSpeed { get; } = 2;

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

        public void Dig()
        {
            Console.WriteLine("DIG IT@!!!");
        }
    }
}