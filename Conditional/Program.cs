using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional Statements");
            Console.WriteLine("---------------------");

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            Console.ReadLine();
        }
    }
}
