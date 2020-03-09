using System;

namespace inheritanceIntro
{

    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Schwing!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna does a barrell roll right");
        }

    }

}