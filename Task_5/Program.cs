using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            //
            // Set the callback method.
            //
            TimerCallback tm = new TimerCallback(Count);

            //
            // Create a timer.
            //
            Timer t = new Timer(tm, num, 0, 2000);

            Thread.Sleep(10000);

            Console.ReadKey();
        }
        static void Count(object obj)
        {
            int x = (int)obj;

            for (int i = 1; i < 5; i++, x++)
            {
                Console.WriteLine("{0}", x * i);
            }
        }    }
}
