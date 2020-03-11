using System;

namespace ZoologicalZaniness
{
    public class Parakeet : IFlying
    {
        public string name { get; set; }
        public int MaximumHeight { get; set; } = 100;
        public void Fly()
        {
            Console.WriteLine($"The {name} flies dazzlingly {MaximumHeight} feet above ground.");
        }
    }
}