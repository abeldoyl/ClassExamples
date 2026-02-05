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
namespace BingoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] drawnBalls = new bool[5, 15];

            drawnBalls[1,0] = true;
            //pause
            Console.Read();
        }
    }
}
