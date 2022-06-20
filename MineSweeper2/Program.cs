namespace MineSweeper2
{
    public class Program
    {


        public static void Main(string[] args)
        {





            
          
            

            while (true)
            {

                // Board.PrintBoard();
                int userInput = 0;

                Intro.UseIntro();
                Board.CreateCell();

                Console.Write("Enter in X: ");
                string coordX = Console.ReadLine();
                int numX = Int32.Parse(coordX);
               

                Console.Write("Enter in Y: ");
                string coordY = Console.ReadLine();
                int numY = Int32.Parse(coordY);

                Console.Clear();
            }

             

            //int[] Bomb = minesweeperField.Index[2];
            //int[] Bonb2 = minesweeperField.Index[3];









        }

        


    }
}