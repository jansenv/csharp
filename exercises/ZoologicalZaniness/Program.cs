using System;
using System.Collections.Generic;

namespace ZoologicalZaniness
{
    class Program
    {
        static void Main(string[] args)
        {
            Digging diggers = new Digging();
            Flying flyers = new Flying();
            Moving movers = new Moving();
            Swimming swimmers = new Swimming();

            Ant Bobby = new Ant();
            BettaFish Brandy = new BettaFish();
            CopperheadSnake Bubs = new CopperheadSnake();
            Finch Brady = new Finch();

            diggers.DiggingAnimalsContainer.Add(Bobby);
            flyers.FlyingAnimalsContainer.Add(Brady);
            movers.MovingAnimalsContainer.Add(Bubs);
            swimmers.SwimmingAnimalsContainer.Add(Brandy);
        }
    }
}
