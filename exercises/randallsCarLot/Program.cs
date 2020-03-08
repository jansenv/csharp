using System;
using System.Collections.Generic;

namespace randallsCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, Dictionary<string, string>>> ListOfVehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            var vehicleObject1 = new Dictionary<string, Dictionary<string, string>>();

            var vehicle1 = new Dictionary<string, string>();
            var salesAgent1 = new Dictionary<string, string>();
            var credit1 = new Dictionary<string, string>();

            vehicle1.Add("year", "2008");
            vehicle1.Add("model", "Damfresh");
            vehicle1.Add("make", "Biotraxquote");
            vehicle1.Add("color", "sky magenta");

            salesAgent1.Add("mobile", "(896) 478-6975");
            salesAgent1.Add("LastName", "Botsford");
            salesAgent1.Add("FirstName", "Shaina");

            credit1.Add("CreditProvider", "J.P.Morgan Chase & Co");
            credit1.Add("Account", "601109582720302");

            vehicleObject1.Add("vehicle", vehicle1);
            vehicleObject1.Add("sales agent", salesAgent1);
            vehicleObject1.Add("credit", credit1);

            ListOfVehicles.Add(vehicleObject1);

            var vehicleObject2 = new Dictionary<string, Dictionary<string, string>>();

            var vehicle2 = new Dictionary<string, string>();
            var salesAgent2 = new Dictionary<string, string>();
            var credit2 = new Dictionary<string, string>();

            vehicle2.Add("year", "2010");
            vehicle2.Add("model", "Hotquadtrax");
            vehicle2.Add("make", "Transtintechno");
            vehicle2.Add("color", "robin egg blue");

            salesAgent2.Add("mobile", "562.300.2912");
            salesAgent2.Add("lastName", "Davis");
            salesAgent2.Add("firstName", "Gerardo");

            credit2.Add("creditProvider", "PNC Financial Services");
            credit2.Add("account", "34578280562836");

            ListOfVehicles.Add(vehicleObject2);

            foreach (Dictionary<string, Dictionary<string, string>> vehicleObject in ListOfVehicles)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> objectKVpair in vehicleObject)
                {
                    Console.WriteLine(objectKVpair.Key);
                    foreach (KeyValuePair<string, string> objectDetail in objectKVpair.Value)
                    {
                        Console.WriteLine($"{objectDetail.Key}: {objectDetail.Value}");
                    }
                }
            }
        }
    }
}
