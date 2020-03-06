using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string name { get; set; } = "Jansenville";
        public string mayor { get; set; } = "Jansen";
        public int year { get; set; } = 1992;
        public List<Building> Buildings = new List<Building>();
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
    }
}