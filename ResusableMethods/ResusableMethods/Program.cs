namespace ResusableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(RunningTotal(5, false));
            }
            Console.WriteLine(RunningTotal());
            Console.WriteLine(RunningTotal(0, true));
            Console.WriteLine(RunningTotal());
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
            
            Console.Read();
        }

        static void TestRunningTotal()
        {
            string userInput = "";
            do
            {
            Console.WriteLine("Enter a number to add to oa running total" +
                "\nenter c to clear\nenter q to quit");
            userInput = Console.ReadLine();
                try
                {
                    RunningTotal(int.Parse(userInput));
                }
                catch (Exception)
                {
                    switch (userInput)
                    {
                        case "c":
                            RunningTotal(0, true);
                            break;
                        case "C":
                            RunningTotal(0, true);
                            break;
                        default:
                            break;
                    }
                }

            Console.WriteLine($"You entered {userInput}");
            Console.WriteLine($"The current total is {RunningTotal}");
            }

                while (userInput != "Q" || userInput != "q");
            for (int i = 0; i < 10; i++);
            {
                RunningTotal(5);
            }
        }

        //[x] keep track of a running total
        //[x] optionally add the integer passed in as an argument
        //[x] return running total
        //[x] optionally clear the running total
        
        static private int _runningTotal = 0;

        static int RunningTotal(int currentValue = 0, bool clear = false)
        {
            _runningTotal += currentValue;
            if (clear)
            {
                _runningTotal = 0;
            }
            return _runningTotal;
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
