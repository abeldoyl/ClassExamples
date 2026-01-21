/*Abel Doyle
 Spring Semester 2026
 RCET2265
 Console Practice Program
https://github.com/abeldoyl/ClassExamples.git */

namespace ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Hello, World!";
            Console.Beep(500, 50000);
            Console.Beep(1000, 500);
            Console.Beep(500, 500);
            */

            string userInput = "hello";
            
            Console.WriteLine("Please Type Some Text");
            userInput = Console.ReadLine();

            Console.WriteLine($"You entered: \"{userInput}\""); // formatted string
            Console.WriteLine("You entered: " + "\"" + userInput + "\""); // concatenate string

            Console.Read();

        }
    }
}
