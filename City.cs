using System;

namespace Planner
{
    public class City
    {
        private string _city { get; set; }
        private string _mayor { get; set; }

        // private string _buildings { get; set; }

        private DateTime _established { get; set; }

        public City(string city)
        {
            _city = city;
        }

        public void Mayor(string mayorName)
        {
            _mayor = mayorName;
        }

        public void Established()
        {
            _established = DateTime.Now;
        }

        // public void Buildings(string buildingName)
        // {
        //     _buildings = buildingName;
        // }

        public void Cities()
        {
            Console.WriteLine($"Name of City: {_city}");
            Console.WriteLine($"Mayor: {_mayor}");
            Console.WriteLine($"Established: {_established}");
        }

    }
}