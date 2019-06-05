using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_7.Run();

            Console.ReadKey();
        }

        public class Task_7
        {
            public static void Run()
            {
                string input = UserString();
                string result = ToCamelCase(input);

                Console.WriteLine($"{System.Environment.NewLine}Output formatted string:");
                Console.WriteLine(result);
            }

            public static string UserString()
            {
                string input = string.Empty;

                Console.WriteLine("Enter the string. Use as a delimiter '-' or '_'.");

                while (true)
                {
                    input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                        break;
                    else
                        Console.WriteLine($"{System.Environment.NewLine}Wrong input!");
                }

                return input;
            }

            public static string ToCamelCase(string input)
            {
                string[] arrStr = input.Split(new char[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

                string output = string.Empty;

                output += arrStr[0];

                for (int i = 1; i < arrStr.Length; i++)
                {
                    output += arrStr[i][0].ToString().ToUpper();
                    output += arrStr[i].Substring(1);
                }

                return output;
            }
        }
    }
}
