namespace ResusableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRandomNumber();
            //pause
            Console.Read();
        }

        static void TestRandomNumber()
        {
            int[] counts = new int[12];
            int max = 10, min = 5, currentNumber = 0, padding = 8;
            
            for (int i = 0; i < 10000; i++)
            {
                //Console.Write(RandomNumberBetween(10, 5).ToString().PadLeft(2));
                currentNumber = RandomNumberBetween(max,min);
                counts[currentNumber] += 1;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.Write(i.ToString().PadLeft(padding) + "|");
            } 
            Console.WriteLine();
            //Makes into colums
            foreach (int count in counts)
            { 
                Console.Write(count.ToString().PadLeft(padding) + "|");
            }
        }
        
        static int RandomNumberBetween(int max, int min)
        {
            int range = max - min + 1;
            Random rand = new Random();
            int randomNumber = rand.Next(range);
            randomNumber += min; // shift value back up to the range between max and min
            return randomNumber;
        }
    }
}
