namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test randomness and range with a for loop
            for (int i = 0; i < 1000; i++)
            {
                //rand.Next(min,Max) max is not incuded
                Random rand = new Random();
                int n = rand.Next(0, 2); // Random number between 1 and 6
                
                Console.Write(n);
            }

            //pause
            Console.Read();
        }
    }
}
