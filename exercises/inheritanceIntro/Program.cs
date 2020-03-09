using System;

namespace inheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();

            // I can still reference the inherited property
            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;

            var myTesla = new Tesla();
            myTesla.MainColor = "Midnight Silver";
            myTesla.MaxOccupancy = 6;

            var myRam = new Ram();
            myRam.MainColor = "Black as midnight on a moonless night";

            var myCessna = new Cessna();
            myCessna.MainColor = "Drug runner White";

            myBike.Drive();
            myTesla.Drive();
            myRam.Drive();
            myCessna.Drive();

            Console.WriteLine(myTesla);

            double price = 15.50;

            Console.WriteLine(price.ToString("C"));
        }
    }
}
