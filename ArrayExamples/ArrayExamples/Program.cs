namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fruits = new string[7];
            string[] daysOfTheWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
            int[,] grid = new int[5, 5];

            /*
            fruits[0] = "apple";
            fruits[1] = "banana";
            fruits[2] = "pear";
            fruits[3] = "kiwi";
            fruits[4] = "watermelon";
            fruits[5] = "pomegranate";
            fruits[6] = "grape";

            //read all the fruits
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            //same with no index or need for known length
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine($"the length of the fruit is: {fruits.Length}");
            */

            for (int colum = 0; colum < 5; colum++)
            {
                for (int row = 0; row < 5; row++)
                {
                    grid[colum, row] = row * colum;
                }
            }

                    Console.Write(grid[3,3]);


            //pause
            Console.Read();
        }
    }
}
