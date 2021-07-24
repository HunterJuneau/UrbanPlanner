using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    class Building
    {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public byte Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume => 3 * Stories * Width * Depth;

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{_address}---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}
