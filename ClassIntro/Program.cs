using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFordBronco = new Car(40000, "Ford", "Bronco", 1982);

            // You "set" the Make here
            Car mySubaru = new Car(10000)
            {
                Make = "Subaru",
                Model = "Outback",
                Year = 1999
            };

            // You "get" the Make here
            Console.WriteLine(mySubaru.Make);

            Console.WriteLine(mySubaru.Description);
            Console.WriteLine(myFordBronco.Description);

            // Invoke the Drive method
            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Drive(60);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service(true);

        }
    }
}
