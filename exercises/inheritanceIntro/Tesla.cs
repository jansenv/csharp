using System;

namespace inheritanceIntro
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes Rumble rumble");
        }

        public override string ToString()
        {
            return "This is my tesla";
        }
    }
}