﻿using System;
using System.Collections.Generic;

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

            Gardenia Gardenia = new Gardenia();
            Gardenia.Color = "White";
            Gardenia.Name = "Ms. G";
            Gardenia.Type = "Gardenia";
            Gardenia.Cost = 1.00;
            Gardenia.WaterSchedule = "Every other week";
            Gardenia.IsAWeed = false;
            Gardenia.Fragrant = true;

            Orchid Orchid = new Orchid();
            Orchid.Color = "Purple";
            Orchid.Name = "Orc";
            Orchid.Type = "Orchid";
            Orchid.Cost = 29.00;
            Orchid.WaterSchedule = "Every 2 days";
            Orchid.IsAWeed = true;
            Orchid.Fragrant = true;

            Tulip Tulip = new Tulip();
            Tulip.Color = "Rainbow";
            Tulip.Name = "Tulip Terry";
            Tulip.Type = "Tulip";
            Tulip.Cost = 0.29;
            Tulip.WaterSchedule = "Never";
            Tulip.CanTiptoeThrough = true;
            Tulip.Fragrant = false;

            FlowerShop MacsFlowerShop = new FlowerShop();
            List<IBirthday> Arrangement = MacsFlowerShop.MakeBirthdayArrangement();

        }
    }
}
