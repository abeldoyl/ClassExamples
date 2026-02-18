namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //WriteToFile();
            //AppendToFile();
            //ReadFile();
            //ReadEntireFile("..\\..\\..\\email.txt");
            FileToArray("..\\..\\..\\email.txt");
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

        static void ReadEntireFile(string filePath)
        {
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    Console.WriteLine(testFile.ReadLine());
                }
                while (testFile.EndOfStream != true);
                {

                }
            }
        }

        static string[,] FileToArray(string filePath)
        {
            string[,] customerData = new string[5, 201];
            string[] temp;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    temp[0] = temp[0].Replace("\"$$", "");
                    Console.WriteLine(temp[0]);
                }
                while (!testFile.EndOfStream);
                {

                }
            }

            return customerData;
        }
    }
}
