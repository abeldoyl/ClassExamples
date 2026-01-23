namespace LoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine($"Count: {i}");
            }

            for (int i = 5; i >= -5; i--)
            {
                Console.WriteLine($"Count: {i}");
            }
            
            
            int number = 1;
           
            do
            {
                Console.WriteLine($"In Do Loop Number: {number}");
                number++;
            } while (number <= 3);
            
            while (number <= 3)

            {
                Console.WriteLine($"In While Loop Number: {number}");
                number++;
            }

            //pause
            Console.Read();
        }
    }
}
