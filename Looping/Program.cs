using System;

namespace LoopingStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping Statements");
            Console.WriteLine("------------------");

            Console.Write("Enter the number of terms: ");
            int numberOfTerms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sequence of Numbers:");

            for (int i = 1; i <= numberOfTerms; i++)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
