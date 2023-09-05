using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Arithmetic Operations");
            Console.WriteLine("---------------------------");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double sum = num1 + num2;
            Console.WriteLine("Sum: " + sum);

            double difference = num1 - num2;
            Console.WriteLine("Difference: " + difference);

            double product = num1 * num2;
            Console.WriteLine("Product: " + product);

            double quotient = num1 / num2;
            Console.WriteLine("Quotient: " + quotient);

            Console.ReadLine();
        }
    }
}
