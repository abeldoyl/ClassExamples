namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            
            string[] fruits = new string[7];
            
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

            //pause
            Console.Read();
        }
    }
}
