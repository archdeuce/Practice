using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Ukrainian : Human
    {
        public override string Name { get; set; }

        public Ukrainian(string name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Привiт, {this.Name}!");
        }
    }
}
