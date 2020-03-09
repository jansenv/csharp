using System;

namespace inheritanceIntro
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaxOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }
}