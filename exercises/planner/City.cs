using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; } = "Jansenville";
        public string Mayor { get; set; } = "Jansen";
        public int Year { get; set; } = 1992;
        public List<Building> Buildings = new List<Building>();

        public City(string _name, string _mayor, int _year)
        {
            _name = Name;
            _mayor = Mayor;
            _year = Year;
        }

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
    }
}