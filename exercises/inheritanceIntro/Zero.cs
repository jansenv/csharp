using System;

namespace inheritanceIntro
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes Bzzzzzz");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero does a sick J-turn");
        }
    }

}