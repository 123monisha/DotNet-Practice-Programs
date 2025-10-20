using System;
using System.Collections.Generic;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            // Add names
            students.Add("Monisha");
            students.Add("Rahul");
            students.Add("Sneha");

            // Remove one name
            students.Remove("Rahul");

            // Sort the list
            students.Sort();

            Console.WriteLine("Student Names:");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
