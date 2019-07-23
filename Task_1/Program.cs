using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();

            c.X = 4;
            c.Y = 5;

            Thread t = new Thread(new ParameterizedThreadStart(Count));

            t.Start(c);

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Main thread: " + i * i);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }

        public class Counter
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Count(object obj)
        {
            for (int i = 1; i < 5; i++)
            {
                Counter tmp = (Counter)obj;

                Console.WriteLine("Secondary stream: " + i * tmp.X * tmp.Y);

                Thread.Sleep(100);
            }
        }
    }
}