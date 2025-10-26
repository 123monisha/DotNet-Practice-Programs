using System;

namespace Practical_Example
{
    // Custom Exception Class
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new InvalidAgeException("You must be 18 or older to vote.");
                }

                Console.WriteLine("You are eligible to vote!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Program ended safely.");
            }

            Console.ReadLine();
        }
    }
}
