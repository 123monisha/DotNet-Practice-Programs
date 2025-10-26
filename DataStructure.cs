using System;
using System.Collections.Generic;

namespace Practical_Example
{
    internal class DataStructure
    {
        static void Main(string[] args)
        {
            List<int> stack = new List<int>();

            // Push elements
            stack.Add(10);
            stack.Add(20);
            stack.Add(30);

            Console.WriteLine("Stack elements:");
            Display(stack);

            // Pop element
            Console.WriteLine("\nPopping top element...");
            if (stack.Count > 0)
            {
                int popped = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                Console.WriteLine("Popped: " + popped);
            }

            // Display again
            Console.WriteLine("\nStack after popping:");
            Display(stack);

            Console.ReadLine();
        }

        static void Display(List<int> stack)
        {
            if (stack.Count == 0)
                Console.WriteLine("Stack is empty!");
            else
            {
                foreach (int item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
