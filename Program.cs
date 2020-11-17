﻿using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building AshwoodModel = new Building("512 8th Avenue");
            AshwoodModel.Width = 200;
            AshwoodModel.Depth = 300;
            AshwoodModel.Stories = 13;
            AshwoodModel.Construct();
            AshwoodModel.Purchase("Faith Magras");
            AshwoodModel.Design("Lacey Walker");

            Building PinecrestModel = new Building("P Sherman 42");
            PinecrestModel.Width = 500;
            PinecrestModel.Depth = 600;
            PinecrestModel.Stories = 13;
            PinecrestModel.Construct();
            PinecrestModel.Purchase("Leah Robinson");
            PinecrestModel.Design("Andrew Herring");

            Building BloomsdaleModel = new Building("555 Green Acers");
            BloomsdaleModel.Width = 1200;
            BloomsdaleModel.Depth = 800;
            BloomsdaleModel.Stories = 13;
            BloomsdaleModel.Construct();
            BloomsdaleModel.Purchase("Chef Gumi");
            BloomsdaleModel.Design("Old Joe");

            // Console.WriteLine($"Address: {AshwoodModel.GetAddress()}");
            // Console.WriteLine("---------------");
            // Console.WriteLine($"Designed by {AshwoodModel.GetDesigners()}");
            // Console.WriteLine($"Constructed on {AshwoodModel.GetDate()}");
            // Console.WriteLine($"Owned by {AshwoodModel.GetOwner()}");
            // Console.WriteLine($"{AshwoodModel.Volume} cubic meters of space");

        }
    }
}