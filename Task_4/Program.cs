using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_4.Run();

            Console.ReadKey();
        }

        public class Task_4
        {
            public static void Run()
            {
                int getPin = ReadUserInput();
                bool check = ValidatePin(getPin);

                Console.WriteLine($"ValidatePin(\"{getPin}\") => {check}.");
            }

            public static int ReadUserInput()
            {
                int pin;

                while (true)
                {
                    Console.WriteLine("Enter PIN-code (xxxx or xxxxxx):");
                    if (Int32.TryParse(Console.ReadLine(), out pin))
                        break;
                }

                return pin;
            }

            public static bool ValidatePin(int pin)
            {
                int count = 0;

                while (pin > 0)
                {
                    pin /= 10;
                    count++;
                }

                if (count == 4 || count == 6)
                    return true;
                else
                    return false;
            }
        }
    }
}
