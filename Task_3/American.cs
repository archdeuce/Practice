using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class American : Human
    {
        public override string Name { get; set; }

        public American(string name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Hello, {this.Name}!");
        }
    }
}
