using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle
    {
        public void DrawEquilateralTriangle(int height)
        {
            Console.WriteLine("Triangle drawing in progress");
            int spacesBeforeAsterisk;
            for (int i = 1; i <= height; i++)
            {
                spacesBeforeAsterisk = (height - i);
                for (int j = 0; j < spacesBeforeAsterisk; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
