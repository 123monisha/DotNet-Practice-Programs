using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Example
{
    internal class FileAndExceptionHandling
    {
        static void Main(string[] args)
        {
            string filepath = "student3.txt";
            StreamWriter writer = null;
            StreamReader reader = null;
            try
            {
                writer = new StreamWriter(filepath);
                writer.WriteLine("hello krishna");
                writer.WriteLine("again we are started!!!");
                writer.WriteLine("Radhaa is waiting");
                writer.WriteLine("bye byee...");
                Console.ReadLine();
                Console.WriteLine("File created and data writtened successfully");
            }
            catch (Exception)
            {
                Console.WriteLine("error while writing the file");
            }
            finally
            {
                writer.Close();
            }
            Console.WriteLine("Shell we start reading a file?");
            try
            {
                reader = new StreamReader(filepath);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error while reading the file");
            }
            finally
            {
                reader.Close();
            }
        }

    }
}
