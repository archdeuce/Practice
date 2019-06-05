using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_5.Run();

            Console.ReadKey();
        }

        class Task_5
        {
            public static void Run()
            {
                int rowsOfTriangle = UserInput();
                int sum = CalculateRowSum(rowsOfTriangle);

                Console.WriteLine($"The sum of the triangular rows is {sum}.");
            }

            public static int UserInput()
            {
                int rows = 0;

                while (true)
                {
                    Console.Write("Enter the number of rows of the triangle: ");

                    if (Int32.TryParse(Console.ReadLine(), out rows) && (rows > 0))
                        break;
                    else
                        Console.WriteLine("Wrong input!");
                }

                return rows;
            }

            public static int CalculateRowSum(int rows)
            {
                int sum = rows * rows * rows;

                return sum;
            }
        }
    }
}
