/*
 * TODO:
 * [x] Track bingo balls drawn in a two dimentional array
 * [x] Display status of all balls on the console
 * [x] Clear all drawn balls to start a new game
 * [x] Let the user quit
 * [x] Draw a random ball
 * [x] Get a random number to determine ball letter
 * [x] Get a random number to determine ball number
 * [x] Check if ball has already been drawn. 
 *     No: mark as drawn, Yes: draw another
 * [x] Usability
 * [ ] Wait to draw first ball
*/
using System.Diagnostics.Metrics;

namespace BingoGame
{
    internal class Program
    {
        //make this global so it can be accessed by all methods
        static bool[,] drawnBalls = new bool[5, 15];

        static void Main(string[] args)
        {
            int ballcount = 0;
            string userInput = "";
            do
            {
                Console.Clear();
                
                if (ballcount < 75)
                {
                    Console.WriteLine("Press \"enter\" to Draw a new ball\n"
                    + "Press \"Q\" at any time to quit\n"
                    + "Press \"C\" to clear the board at any time");
                    DrawBall();
                    ballcount++;
                }
                else
                {
                    Console.WriteLine("All balls have been drawn");
                    Console.WriteLine("Press \"Q\" to quit");
                    Console.WriteLine("Press \"C\" to clear the board to start a new game");
                }
                Console.WriteLine($"Ball Count: {ballcount}");
                Display();
                userInput = Console.ReadLine(); //Fixed double drawn balls issue
                if (userInput == "c" || userInput == "C")
                {
                    ClearDrawBalls();
                    ballcount = 0;
                }

            } while (userInput != "Q" && userInput != "q" == true);
            Console.Clear();
            Console.WriteLine("Have a nice day");
            //pause
            Console.Read();
        }


        static void Display()
        {
            int padding = 5;
            int prettyNumber = 0;
            string placeHolder = "";
            string columnSeperator = " |";
            string currentRow = "";
            //print heading row
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + columnSeperator);
            }
            Console.WriteLine();

            // print the rest of the rows
            for (int number = 1; number <= 15; number++)
            {
                //assemble the row
                for (int letter = 0; letter < 5; letter++)
                {
                    if (drawnBalls[letter, number - 1])
                    {
                        prettyNumber = number + (letter * 15); //offset the number by the letter column
                        currentRow += prettyNumber.ToString().PadLeft(padding) + columnSeperator;
                    }
                    else
                    {
                        currentRow += placeHolder.PadLeft(padding) + columnSeperator;
                    }
                }
                Console.WriteLine(currentRow);
                currentRow = ""; //reset 
            }
        }

        static void DrawBall()
        {
            int letter = 0, number = 0;
            do
            {
                letter = RandomNumberZeroTo(4);
                number = RandomNumberZeroTo(14);

            } while (drawnBalls[letter, number]);

            drawnBalls[letter, number] = true;

        }
        /// <summary>
        /// Get a random integer from 0 to max inclusive.
        /// </summary>
        /// <param name="max"></param>
        /// <returns>integer</returns>
        static private int RandomNumberZeroTo(int max)
        {
            int range = max + 1; //make max inclusive
            Random rand = new Random();
            return rand.Next(range);

        }

        static void ClearDrawBalls()
        {
            for (int letter = 0; letter < 5; letter++)
            {
                for(int number = 0; number < 15; number++)
                {
                    drawnBalls[letter, number] = false;
                }
            }

        }
    }

}
