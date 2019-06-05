using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Russian : Human
    {
        public override string Name { get; set; }

        public Russian(string name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Привет, {this.Name}!");
        }
    }
}
