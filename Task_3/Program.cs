using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 3. Insert another line at the specified position of the line.
            //
            Console.WriteLine("Enter the first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string secondString = Console.ReadLine();

            Console.WriteLine($"Enter a position to insert the first row into the second [0 - {secondString.Length}]:");
            int insertPosition = Convert.ToInt32(Console.ReadLine());

            string resultString = secondString.Insert(insertPosition, firstString);

            Console.WriteLine($"Result:");
            Console.WriteLine(resultString);

            Console.ReadKey();
        }
    }
}
