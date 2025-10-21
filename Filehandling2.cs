using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Practical_Example
{
    internal class FileeHandle
    {
        static void Main(string[] args)
        {
            string filepath = "D:\\student.txt";
            string content = "hello krishna...";
            if (File.Exists(filepath))
            {
                Console.Write("file is alreday exist");
            }
            else
            {
                File.WriteAllText(filepath, content);
            }
            Console.WriteLine(File.ReadAllText(filepath));
            string content2 = "hello radha!!";
            File.AppendAllText(filepath, content2);
            Console.WriteLine(File.ReadAllText(filepath));
        }
    }
}
