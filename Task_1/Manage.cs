using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Manage
    {
        public void Run()
        {
            Random rnd = new Random();

            Pc newPc = new Pc(Convert.ToBoolean(rnd.Next(2)));

            Monitor newMonitor = new Monitor(Convert.ToBoolean(rnd.Next(2)));

            while (true)
            {
                Console.WriteLine(new String('-', 23));

                newPc.Switch();
                newPc.ToString();

                newMonitor.Switch();
                newMonitor.ToString();

                Console.ReadKey();
            }
        }
    }
}
