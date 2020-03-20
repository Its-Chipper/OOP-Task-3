using System;
using System.IO;
using System.Linq;

namespace OOP_Task_3
{
    class Program
    {
        public static string Path;
        public static string[] File1String;
        public static string[] File2String;
        static void Main(string[] args)
        {
            FileInput();

            if(File1String.SequenceEqual(File2String))
            {
                Console.WriteLine("These files are exactly the same");
            }
            else
            {
                Console.WriteLine("These files are not exactly the same");
            }
        }

        static string[] LoadFile(string FileName)
        {
            Path = Directory.GetCurrentDirectory();
            return File.ReadAllLines(Path.Substring(0, Path.IndexOf("bin") - 11) + (FileName) + ".txt");
        }

        static void FileInput()
        {
            string UserInput = "";

            Console.WriteLine("File 1:");
            while (true)
            {
                try
                {
                    UserInput = Console.ReadLine();
                    File1String = LoadFile(UserInput);
                    break;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"Error: {UserInput}.txt isn't in the directory - {Path.Substring(0, Path.IndexOf("bin") - 11)}");
                }
            }

            Console.WriteLine("File 2:");
            while (true)
            {
                try
                {
                    UserInput = Console.ReadLine();
                    File2String = LoadFile(UserInput);
                    break;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"Error: {UserInput}.txt isn't in the directory - {Path.Substring(0, Path.IndexOf("bin") - 11)}");
                }
            }
        }


    }
}
