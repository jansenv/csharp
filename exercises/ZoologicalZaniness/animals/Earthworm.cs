using System;

namespace ZoologicalZaniness
{
    public class Earthworm : IDigging, IMoving
    {
        public string name { get; set; }
        public int MaximumDepth { get; set; } = 2;
        public int MaximumSpeed { get; set; } = 2;
        public void Dig()
        {
            Console.WriteLine($"The {name} digs a meager {MaximumDepth} inches below ground.");
        }
        public void Move()
        {
            Console.WriteLine("I like to move it move it");
        }
    }
}