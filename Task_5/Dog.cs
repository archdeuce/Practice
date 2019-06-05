using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Dog : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Собака {0} кусает", Name);
        }
    }
}
