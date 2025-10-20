using System;
using System.IO;

namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\sample.txt"; // You can change the path if needed
            string content = "Hello! This is my first file handling program.";

            // Write data into file
            File.WriteAllText(path, content);
            Console.WriteLine("Data written to file successfully.");

            // Read data from file
            string data = File.ReadAllText(path);
            Console.WriteLine("Data from file: " + data);

            Console.ReadLine();
        }
    }
}
