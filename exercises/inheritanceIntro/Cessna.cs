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

    }

}