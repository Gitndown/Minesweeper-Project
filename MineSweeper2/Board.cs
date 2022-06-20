using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper2
{
    public class Board
    {

        Cell[,] minesweeperField = new Cell[10, 10];
        public static void CreateCell()  // Create the Grid
        {

            Cell[,] minesweeperField = new Cell[10, 10]; // [x, y] X is horizontal axis Y is vertical axis

            for (int x = 0; x < minesweeperField.Length; x++)
            {
                for ( int y = 0; y < minesweeperField.Length; y++)
                {
                          minesweeperField[x, y] = new Cell();
                    




                }

                
                Console.Write("\n");
                Console.Write(x.ToString());


            }

        }




        // add new cells to populate the grid




    }

    // public static void PrintBoard()   // Draws the grid for visual reference
    // {
    //     Cell[,] minesweeperField = new Cell[10, 10]; // [x, y] X is horizontal axis Y is vertical axis
    //     for (int x = 0; x < minesweeperField.GetLength(0); x++)
    //     {
    //         for (int y = 0; y < minesweeperField.GetLength(1); y++)
    //         {
    //             Console.Write("#");
    // 
    //         }
    //         Console.Write("\n");
    //     }
    // }


















    

}
