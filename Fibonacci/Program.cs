using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < n; i++)
            {
                int result = Fibonacci(i);
                Console.Write(result + " ");
            }

            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
