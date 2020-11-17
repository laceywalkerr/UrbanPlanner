using System;

namespace Planner
{
    public class Building
    {
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

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

        public Building(string address)
        {
            _address = address;
        }

        // public string GetAddress()
        // {
        //     return _address;
        // }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        // public DateTime GetDate()
        // {
        //     return _dateConstructed;
        // }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }

        // public string GetOwner()
        // {
        //     return _owner;
        // }

        public void Design(string designer)
        {
            _designer = designer;
        }

        // public string GetDesigners()
        // {
        //     return _designer;
        // }

        public void Buildings()
        {
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }

}