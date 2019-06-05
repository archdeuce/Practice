using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_6.Run();

            Console.ReadKey();
        }

        public class Task_6
        {
            public static void Run()
            {
                string firstString = UserInputCheck();
                string secondString = UserInputCheck();
                string resultString = UnicalSymbolString(firstString, secondString);

                Console.WriteLine($"{System.Environment.NewLine}Displaying unique characters from 2 strings in sorted form:");
                Console.WriteLine(resultString);
            }

            public static string UserInputCheck()
            {
                string output = string.Empty;

                Console.WriteLine($"{System.Environment.NewLine}Enter character string [a..z]");

                while (true)
                {
                    output = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(output))
                        break;
                    else
                        Console.WriteLine($"{System.Environment.NewLine}Wrong input!");
                }

                return output;
            }

            public static string UnicalSymbolString(string firstString, string secondString)
            {
                string output = string.Empty;

                string tmpStr = firstString + secondString;

                for (int i = 0; i < tmpStr.Length; i++)
                {
                    bool isExist = false;

                    for (int j = 0; j < output.Length; j++)
                    {
                        if (tmpStr[i] == output[j])
                        {
                            isExist = true;
                            break;
                        }
                    }

                    if (isExist == false)
                    {
                        output += tmpStr[i];
                        isExist = false;
                    }
                }

                char[] characters = output.ToArray();

                Array.Sort(characters);

                return new string(characters);
            }
        }
    }
}
