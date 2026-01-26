namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string userInput = "";
                int result = 0;
                bool isValid = false;
                string message = "";

                do
                {
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine("Enter \"Q\" to quit");
                    userInput = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"You entered {userInput}");

                    try
                    {
                        // risky code
                        result = int.Parse(userInput);
                        isValid = true;
                    }
                    catch (Exception ex)
                    {
                        if (userInput == "Q" || userInput == "q"
                            )
                        {
                            message = $"Have a nice day!";
                            isValid = true;
                        }
                        else
                        {
                            message = $"{userInput} is not a number";
                        }
                    }

                }
                while (!isValid);
                message = $"{result} is a number";



                //pause
                Console.ReadLine();

            }

        }

    }
}
