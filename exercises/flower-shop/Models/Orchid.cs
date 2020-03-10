using System;

namespace flower_shop
{
    class Orchid : IMothersDay
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string WaterSchedule { get; set; }
        public bool IsAWeed { get; set; }
        public bool Fragrant { get; set; }
        public double StemLength { get; set; }

    }
}