using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Diamond
    {
        public void DrawEquilateralDiamond(int height)
        {
            Console.WriteLine("Diamond drawing in progress");
            int topHeight = (height / 2) + 1;
            int bottomHeight = height / 2;
            int spacesBeforeAsterisk = 0;
            for (int i = 0; i <= topHeight; i++)
            {
                spacesBeforeAsterisk = (topHeight - i);
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

            for (int i = bottomHeight; i > 0; i--)
            {

                spacesBeforeAsterisk = (bottomHeight - i);
                for (int j = 0; j <= spacesBeforeAsterisk; j++)
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
