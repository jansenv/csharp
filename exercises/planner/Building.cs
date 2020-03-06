using System;

namespace Planner
{
    public class Building
    {
        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }
        private string _designer = "Jansen";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public override string ToString()
        {
            return ($"Address: {_address}, Constructed On: {_dateConstructed}, Owned By: {_owner}, Volume: {Volume} cubic meters of space");
        }
    }
}