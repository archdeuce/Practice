using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Lynx : Animal, IPurr
    {
        public override void Bite()
        {
            Console.WriteLine("Рысь {0} кусает", Name);
        }

        public void Purr()
        {
            Console.WriteLine("Рысь {0} мурчит", Name);
        }
    }
}
