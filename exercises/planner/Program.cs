using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEighth = new Building("512 8th Avenue")
            {
                Width = 250,
                Depth = 250,
                Stories = 5
            };

            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Mr. 5128th");

            // Console.WriteLine(FiveOneTwoEighth);

            Building OldNSS = new Building("500 Interstate Blvd S")
            {
                Width = 100,
                Depth = 100,
                Stories = 3
            };

            OldNSS.Construct();
            OldNSS.Purchase("John Wark");

            // Console.WriteLine(OldNSS);

            Building NSS = new Building("301 Plus Park Blvd")
            {
                Width = 125,
                Depth = 75,
                Stories = 5
            };

            NSS.Construct();
            NSS.Purchase("Steve B");

            // Console.WriteLine("NSS");

            City Megalopolis = new City("Megalopolis", "Superman", 1933);

            Megalopolis.AddBuilding(FiveOneTwoEighth);
            Megalopolis.AddBuilding(OldNSS);
            Megalopolis.AddBuilding(NSS);

            foreach (Building building in Megalopolis.Buildings)
            {
                Console.WriteLine(building);
            }
        }
    }
}