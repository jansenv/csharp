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
        public virtual void Turn()
        {
            Console.WriteLine("The vehicle carefully turns right");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop");
        }
    }
}