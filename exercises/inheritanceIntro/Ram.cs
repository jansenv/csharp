using System;

namespace inheritanceIntro
{

    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes MRRRRRRM!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram screeches to a halt.");
        }
    }


}