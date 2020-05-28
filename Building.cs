using System;

namespace Planner
{
    // Define class here
    public class Building
    {

        private string _designer = "Brennen Tatum";
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
                return Width * Depth * Stories * 3;
            }
        }
        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string Owner)
        {
            _owner = Owner;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }
    }
}