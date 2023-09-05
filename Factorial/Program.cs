using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine("Factorial of {0} is {1}", number, factorial);
            Console.ReadLine();
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
