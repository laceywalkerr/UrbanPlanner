using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~~ Buildings ~~~~~~~~~~~~~
            Building ashwoodModel = new Building("512 8th Avenue");
            ashwoodModel.Width = 200;
            ashwoodModel.Depth = 300;
            ashwoodModel.Stories = 13;
            ashwoodModel.Construct();
            ashwoodModel.Purchase("Faith Magras");
            ashwoodModel.Design("Lacey Walker");

            Building pineCrestModel = new Building("P Sherman 42");
            pineCrestModel.Width = 500;
            pineCrestModel.Depth = 600;
            pineCrestModel.Stories = 13;
            pineCrestModel.Construct();
            pineCrestModel.Purchase("Leah Robinson");
            pineCrestModel.Design("Andrew Herring");

            Building bloomsdaleModel = new Building("555 Green Acers");
            bloomsdaleModel.Width = 1200;
            bloomsdaleModel.Depth = 800;
            bloomsdaleModel.Stories = 13;
            bloomsdaleModel.Construct();
            bloomsdaleModel.Purchase("Chef Gumi");
            bloomsdaleModel.Design("Old Joe");

            // Console.WriteLine($"Address: {ashwoodModel.GetAddress()}");
            // Console.WriteLine("---------------");
            // Console.WriteLine($"Designed by {ashwoodModel.GetDesigners()}");
            // Console.WriteLine($"Constructed on {ashwoodModel.GetDate()}");
            // Console.WriteLine($"Owned by {ashwoodModel.GetOwner()}");
            // Console.WriteLine($"{ashwoodModel.Volume} cubic meters of space");

            // ashwoodModel.Buildings();
            // pineCrestModel.Buildings();
            // bloomsdaleModel.Buildings();

            //~~~~~~~~~~~~ Cities ~~~~~~~~~~~~~
            City megalopolis = new City("Megapolis");
            megalopolis.Mayor("Dolly Parton");

            // foreach (Building building in megalopolis.Buildings)
            // {
            //     Console.WriteLine($"calling buildings: {megalopolis.Buildings}.");
            // }

            City gotham = new City("Gotham");
            gotham.Mayor("Aubrey James");

            megalopolis.Cities();
            gotham.Cities();

        }
    }
}