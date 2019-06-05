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
            Human[] humans = new Human[]
            {
                new Ukrainian("Вася"),
                new Russian("Петя"),
                new American("Piter")
            };

            foreach (var item in humans)
            {
                item.SayHello();
            }

            Console.ReadLine();
        }
    }
}
