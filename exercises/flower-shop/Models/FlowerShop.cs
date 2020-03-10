using System;
using System.Collections.Generic;

namespace flower_shop
{
    class FlowerShop
    {
        public List<Gardenia> GardeniaList { get; set; } = new List<Gardenia>();
        public List<Orchid> OrchidList { get; set; } = new List<Orchid>();
        public List<Rose> RoseList { get; set; } = new List<Rose>();
        public List<Tulip> TulipList { get; set; } = new List<Tulip>();

        public List<IMothersDay> MakeMothersDayArrangement()
        {
            List<IMothersDay> Arrangement = new List<IMothersDay>();
            Arrangement.Add(new Gardenia());
            Arrangement.Add(new Gardenia());
            Arrangement.Add(new Orchid());
            Arrangement.Add(new Orchid());
            Arrangement.Add(new Orchid());

            return Arrangement;
        }

        public List<IBirthday> MakeBirthdayArrangement()
        {
            List<IBirthday> Arrangement = new List<IBirthday>();
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Tulip());
            Arrangement.Add(new Tulip());

            return Arrangement;
        }

        public List<IGetWell> MakeGetWellArrangement()
        {
            List<IGetWell> Arrangement = new List<IGetWell>();
            Arrangement.Add(new Crabgrass());
            Arrangement.Add(new Crabgrass());
            Arrangement.Add(new Crabgrass());

            return Arrangement;
        }
    }
}
