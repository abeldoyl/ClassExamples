namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(5 + 5); // addition
            Console.WriteLine(5 - 5); // subtraction
            Console.WriteLine(5 * 5); // multiplication
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

            // compound operators
            int a = 5; // assign 5 to variable a
            a = a + 9;
            //a += 9;
            Console.WriteLine(a);

            Console.WriteLine(++a); // increments a by one after operation
            Console.WriteLine(a);
            Console.WriteLine(a++); // increments a by one but ony shows after rewriting a again
            Console.WriteLine(a);
            

            // formated operations on colsole
            int firstNumber = 5;
            int secondNumber = 10;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");


            //pause
            Console.Read();
        }
    }
}
