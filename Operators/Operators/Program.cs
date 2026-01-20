namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(5 + 5);
            Console.WriteLine(5 - 5);
            Console.WriteLine(5 * 5);
            Console.WriteLine(13 / 5); // integer division
            Console.WriteLine(13 % 5); // remainder
            Console.WriteLine(13d / 5d); // floating point division
            Console.WriteLine(13.0 / 5.0); // floating point division
            Console.WriteLine(13.0 / 5); // floating point division
            Console.WriteLine(13 / 5.0); // floating point division

            Console.WriteLine(5 > 2); // a is greater than b
            Console.WriteLine(5 < 2); // a is less than b
            Console.WriteLine(5 == 2); // a is equal to b
            Console.WriteLine(5 != 2); // a is not equal to b
            Console.WriteLine(5 >= 2); // a is greater than or equal to b
            Console.WriteLine(5 <= 2); // a is less than or equal to b

            //pause
            Console.Read();
        }
    }
}
