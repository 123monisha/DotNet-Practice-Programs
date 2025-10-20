using System;

namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers!");
            }
            finally
            {
                Console.WriteLine("Program ended safely.");
            }

            Console.ReadLine();
        }
    }
}
