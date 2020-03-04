using System;
using System.Collections.Generic;

namespace randallsCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            Dictionary<string, Dictionary<string, string>> sale = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> vehicle = new Dictionary<string, string>();
            Dictionary<string, string> salesAgent = new Dictionary<string, string>();
            Dictionary<string, string> credit = new Dictionary<string, string>();

            vehicle.Add("year", "2008");
            vehicle.Add("model", "Damfresh");
            vehicle.Add("make", "Biotraxquote");
            vehicle.Add("color", "sky magenta");
            salesAgent.Add("mobile", "(896) 478-6975");
            salesAgent.Add("Last Name", "Botsford");
            salesAgent.Add("First Name", "Shaina");
            credit.Add("Credit Provider", "J.P.Morgan Chase & Co");
            credit.Add("Account", "601109582720302");

            sale.Add("vehicle", vehicle);
            sale.Add("sales agent", salesAgent);
            sale.Add("credit", credit);

            vehicles.Add(sale);

            Dictionary<string, Dictionary<string, string>> sale2 = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> vehicle2 = new Dictionary<string, string>();
            Dictionary<string, string> salesAgent2 = new Dictionary<string, string>();
            Dictionary<string, string> credit2 = new Dictionary<string, string>();

            vehicle2.Add("year", "2010");
            vehicle2.Add("model", "Hotquadtrax");
            vehicle2.Add("make", "Transtintechno");
            vehicle2.Add("color", "robin egg blue");
            salesAgent2.Add("mobile", "562.300.2912");
            salesAgent2.Add("lastName", "Davis");
            salesAgent2.Add("firstName", "Gerardo");
            credit2.Add("creditProvider", "PNC Financial Services");
            credit2.Add("account", "34578280562836");

            vehicles.Add(sale2);

            foreach (Dictionary<string, Dictionary<string, string>> saleDic in vehicles)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> salePair in saleDic)
                {
                    Console.WriteLine(salePair.Key);
                    foreach (KeyValuePair<string, string> section in salePair.Value)
                    {
                        Console.WriteLine($"{section.Key}: {section.Value}");
                    }
                }
            }
        }
    }
}
