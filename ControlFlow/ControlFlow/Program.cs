


namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            if (score >= 100)
            {
                Console.WriteLine("Ace!");
            }
            else if (score >= 90)
            {
                Console.WriteLine("Excellent! You got an A.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Good job! You passed.");
            }
            else
            {
                Console.WriteLine("Keep trying! Practice makes perfect.");
            }

            //pause
            Console.Read();
            
            
        }
    }
}
