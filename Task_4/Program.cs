using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static int x = 0;

        static object l = new object();

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread t = new Thread(Count);

                t.Name = "Поток " + i.ToString();

                t.Start();
            }
        }

        static void Count()
        {
            lock (l)
            {
                x = 1;

                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);

                    x++;

                    Thread.Sleep(100);
                }
            }
        }
    }
}
