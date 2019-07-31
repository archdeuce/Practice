using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge
{
    class Program
    {
        static void Main(string[] args)
        {
            new Manager().Execute();

            Console.ReadKey();
        }
    }
}
