using System;

namespace TableForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Table Form");
            Console.WriteLine("----------");

            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    string cellValue = "(" + i + "," + j + ")";
                    Console.Write(cellValue.PadRight(12));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
