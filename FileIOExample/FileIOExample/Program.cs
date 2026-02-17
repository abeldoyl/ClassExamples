namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //WriteToFile();
            //AppendToFile();
            ReadFile();
            //pause
            Console.Read();
        }

        static void WriteToFile()
        {
            using (StreamWriter testFile = File.CreateText("..\\..\\..\\TestFile.txt"))
            //using ..\ moves the file up a level in file manager the second \ is to
            //make the code read the \ as a comand not as a comment
            
            {
                testFile.WriteLine("Wake up Neo...");
            }
        }

        static void AppendToFile()
        {
            using (StreamWriter testFile = File.AppendText("..\\..\\..\\TestFile.txt"))
            {
                testFile.WriteLine("Follow the white rabbit...");
            }
        }

        static void ReadFile()
        {
            using (StreamReader testFile = new StreamReader("..\\..\\..\\TestFile.txt"))
            {
                
                Console.WriteLine(testFile.ReadLine());
                Console.WriteLine(testFile.ReadLine());
            }
        }
    }
}
