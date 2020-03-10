using System;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose MrThorny = new Rose();
            MrThorny.Color = "Purple";
            MrThorny.Name = "Mr. Thorny";
            MrThorny.Type = "Rose";
            MrThorny.Cost = 4.99;
            MrThorny.WaterSchedule = "Every Tuesday at 3pm";
            MrThorny.Thorny = true;
            MrThorny.Fragrant = false;
        }
    }
}
