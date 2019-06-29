using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Tree : Plant
    {
        public int Branches { get; set; }

        public Tree(string name, PlantColor color, int height, int branches)
            : base(name, color, height)
        {
            this.Branches = branches;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The tree has {this.Branches} branches.");
        }
    }
}
