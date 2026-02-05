/*
 * TODO:
 * [ ] Track bingo balls drawn in a two dimentional array
 * [ ] Display status of all balls on the console
 * [ ] Clear all drawn balls to start a new game
 * [ ] Let the user quit
 * [ ] Draw a random ball
 * [ ] Get a random number to determine ball letter
 * [ ] Get a random number to determine ball number
 * [ ] Check if ball has already been drawn. 
 *     No: mark as drawn, Yes: draw another
*/
using System.Diagnostics.Metrics;

namespace BingoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] drawnBalls = new bool[5, 15];

            drawnBalls[1,0] = true;

            Display();
            //pause
            Console.Read();
        }

        static void Display()
        {
            int padding = 5;
            //print heading row
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + " |");
            }
            Console.WriteLine();

            //print the rest of rows
            for (int letter = 0; letter < 5; letter++)
            {
                Console.Write(letter.ToString().PadLeft(padding) + " |" );
            }

        }
    }
}
