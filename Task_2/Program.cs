using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(5, 4);

            Thread t = new Thread(c.Count);

            t.Start();

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Main thread: " + i * i);
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

        public class Counter
        {
            private int x;

            private int y;

            public Counter(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Count()
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("Secondary stream: " + i * x * y);
                    Thread.Sleep(800);
                }
            }
        }
    }
}
