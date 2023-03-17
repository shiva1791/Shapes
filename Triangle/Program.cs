using System;

namespace Shapes

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.WriteLine("How big of an equilateral Triangle?");
            int triangleRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number entered by user is {triangleRows}");

            Triangle triangle = new Triangle();
            triangle.DrawEquilateralTriangle(triangleRows);

            Console.WriteLine("How big of a Diamond, an odd number would be good?");
            int diamondRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number entered by user is {diamondRows}");

            Diamond diamond = new Diamond();
            diamond.DrawEquilateralDiamond(diamondRows);
        }
    }
}
