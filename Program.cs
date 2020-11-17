using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suuuuuuuuup!");

            Building fiveOneTwoEight = new Building("512 8th Avenue");
            Building threeThreeThree = new Building("P Sherman 42");
            Building oneTwoThree = new Building("555 Green Acers");
            Building sixTwoSix = new Building("Buckingham Palace, London, England");

            fiveOneTwoEight.Width = 200;
            fiveOneTwoEight.Height = 300;
            fiveOneTwoEight.Stories = 13;
            fiveOneTwoEight.Construct();
            fiveOneTwoEight.Purchase("Faith");
            fiveOneTwoEight.Design("Lacey");

            Console.WriteLine($"Designed by {fiveOneTwoEight.GetDesigners()}");
            Console.WriteLine($"Designed by {fiveOneTwoEight.GetDesigners()}");
        }
    }
}