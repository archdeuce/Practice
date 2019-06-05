using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Cat : Animal, IPurr
    {
        public override void Bite()
        {
            Console.WriteLine("Кошка {0} кусает", Name);
        }

        public void Purr()
        {
            Console.WriteLine("Кошка {0} мурчит", Name);
        }
    }
}
