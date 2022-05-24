using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper2
{
    public class GridPlan
    {

        // Properties
        public const int X = 20;
        public const int Y = 20;
        public static void Draw()
        {
            for (int y = Y - 1; y >= 0; y--)
            {

                for (int x = 0; x < X; x++)
                {
                    Console.Write(" . ");
                }

                Console.Write('\n');
            }
        }







    }
    
}
